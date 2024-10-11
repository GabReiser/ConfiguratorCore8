using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConfiguratorNewest.Enum;
using Smart.Utils;
using RestSharp;

namespace ConfiguratorNewest.Instalation.Ricoh
{
    public class ManagementRICOH : IEmbedded
    {
        #region Constantes
        private const string DS_EMBEDDED_FILE_NAME = "34101505";
        private string ANDROID_EMBEDDED_CODE = "1711276261";
        private string EMBEDDED_BASE_DIRECTORY = @"Embedded\RICOH\";
        private const int INTERVAL_SLEEPING = 10000;
        #endregion

        #region Propriedades
        private static bool _isAndroid;
        private static int MAX_NUM_TRIES = 25;
        private readonly RemoteCertificateValidationCallback _originalCallback = ServicePointManager.ServerCertificateValidationCallback;
        private bool _containsException;
        #endregion

        public delegate void CustomEventHandler(object sender, CustomEventArgs e);
        public static event CustomEventHandler OnLogEvent;

        public void LogEvent(String param)
        {
            if (OnLogEvent != null && !String.IsNullOrEmpty(param))
            {
                if (!_containsException && param.ToLower().Contains("exception"))
                    _containsException = true;
                OnLogEvent(this, new CustomEventArgs { Message = param });
            }
        }

        private void ProcessAction(EmbeddedParamsInfo info, ActionType action, Company company)
        {
            validateComany(info);
            _isAndroid = info.CheckIsAndroid();
            if (_isAndroid)
                this.LogEvent("Android device");
            if ((action == ActionType.Uninstall) || !_isAndroid)
                this.executeRxopCommand(_isAndroid ? RxopCommandType.UNINSTALL : RxopCommandType.STOP_UNINSTALL, info, company);
            if (action == ActionType.Install)
                this.executeRxopCommand(_isAndroid ? RxopCommandType.INSTALL : RxopCommandType.INSTALL_START, info, company);
            if (!_containsException && ((action == ActionType.Install && !_isAndroid) || (action == ActionType.Uninstall)))
                this.executeRxopCommand(RxopCommandType.REBOOT, info, company);
        }

        public void Install(EmbeddedParamsInfo info, bool isConfigurate, Company company)
        {
            try
            {
                if (!isConfigurate)
                    ProcessAction(info, ActionType.Install, company);
                else
                    _isAndroid = true;

                if (_isAndroid)
                    SetupAndroidApp(info);
            }
            catch (FileNotFoundException e)
            {
                LogEvent(string.Format("FileNotFoundException: {0} Path: {1}", e.Message, e.FileName));
            }
            catch (Exception e)
            {
                LogEvent(string.Format("Exception: {0}", e.Message));
            }

        }

        public void Uninstall(EmbeddedParamsInfo info, Company company)
        {
            try
            {
                ProcessAction(info, ActionType.Uninstall, company);
            }
            catch (FileNotFoundException e)
            {
                LogEvent(string.Format("FileNotFoundException: {0} Path: {1}", e.Message, e.FileName));
            }
            catch (Exception e)
            {
                LogEvent(string.Format("Exception: {0}", e.Message));
            }

        }

        private void executeRxopCommand(RxopCommandType commandType, EmbeddedParamsInfo impressoraInfo, Company company)
        {
            validateComany(impressoraInfo);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string rxopClientJarPathDirectory = @"Embedded\" + company.ToString().ToUpper().Trim() + @"\RXOP\rxopClient.jar";
            string rxopClientJarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rxopClientJarPathDirectory);
            if (!File.Exists(rxopClientJarPath))
                throw new FileNotFoundException("Rxop client JAR not found.", rxopClientJarPath);

            string tempDirPath = null;
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = "java";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.RedirectStandardInput = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);
                    p.StartInfo.StandardErrorEncoding = Encoding.GetEncoding(850);
                    p.EnableRaisingEvents = true;

                    p.OutputDataReceived += (sender, args) => this.LogEvent(args.Data);
                    p.ErrorDataReceived += (sender, args) => this.LogEvent(args.Data);

                    StringBuilder arguments = new StringBuilder();

                    switch (commandType)
                    {
                        case RxopCommandType.INSTALL:
                            arguments.AppendFormat("-jar \"{0}\" {1} {2} ", rxopClientJarPath, commandType.GetDescription(), impressoraInfo.DsIPMFP);
                            string apkZipPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, EMBEDDED_BASE_DIRECTORY, ANDROID_EMBEDDED_CODE, ANDROID_EMBEDDED_CODE + ".zip");
                            arguments.AppendFormat(" \"{0}\"", apkZipPath);
                            break;
                        case RxopCommandType.INSTALL_START:
                            //arguments.AppendFormat("java -jar \"{0}\" {1} {2}", rxopClientJarPath, commandType.GetDescription(), impressoraInfo.DsIPMFP);

                            do
                            {
                                tempDirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                            }
                            while (Directory.Exists(tempDirPath));
                            Directory.CreateDirectory(tempDirPath);

                            string embeddedBaseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Embedded\RICOH\", DS_EMBEDDED_FILE_NAME);

                            string origZipFilePath = Path.Combine(embeddedBaseDir, String.Concat(DS_EMBEDDED_FILE_NAME, ".zip"));
                            if (!File.Exists(origZipFilePath))
                                throw new FileNotFoundException("Embedded ZIP file not found.", origZipFilePath);

                            string origDalpFilePath = Path.Combine(embeddedBaseDir, "SmartShare.dalp");
                            if (!File.Exists(origDalpFilePath))
                                throw new FileNotFoundException("Embedded DALP file not found.", origDalpFilePath);

                            string destDalpFilePath = Path.Combine(embeddedBaseDir, "SmartShare_install.dalp");
                            string destZipFilePath = Path.Combine(embeddedBaseDir, String.Concat(DS_EMBEDDED_FILE_NAME, "_install", ".zip"));

                            string destDalpFileText = File.ReadAllText(origDalpFilePath, Encoding.UTF8).Replace("#URLWEBSERVICE#", impressoraInfo.DsUrlWebService);
                            File.WriteAllText(destDalpFilePath, destDalpFileText, Encoding.UTF8);

                            File.Copy(origZipFilePath, destZipFilePath, true);

                            using (ZipArchive zipArchive = ZipFile.Open(destZipFilePath, ZipArchiveMode.Update))
                            {
                                zipArchive.CreateEntryFromFile(destDalpFilePath, Path.GetFileName(origDalpFilePath));
                            }

                            arguments.AppendFormat("-jar \"{0}\" install-start \"{1}\" \"{2}\" ", rxopClientJarPath, impressoraInfo.DsIPMFP, destZipFilePath);

                            //try
                            //{
                            //    File.Delete(destDalpFilePath);
                            //    File.Delete(destZipFilePath);
                            //}
                            //catch (Exception){}

                            break;
                        case RxopCommandType.UNINSTALL:
                            arguments.AppendFormat("-jar \"{0}\" {1} {2} ", rxopClientJarPath, commandType.GetDescription(), impressoraInfo.DsIPMFP);
                            arguments.Append(" " + ANDROID_EMBEDDED_CODE);
                            break;
                        case RxopCommandType.STOP_UNINSTALL:
                            arguments.AppendFormat("-jar \"{0}\" stop-uninstall \"{1}\" \"{2}\" ", rxopClientJarPath, impressoraInfo.DsIPMFP, DS_EMBEDDED_FILE_NAME);

                            break;
                        case RxopCommandType.REBOOT:
                            arguments.AppendFormat("-jar \"{0}\" reboot \"{1}\" ", rxopClientJarPath, impressoraInfo.DsIPMFP);
                            break;
                        case RxopCommandType.SET_PRIORITY:
                            arguments.Append(" 34101505 set");
                            break;
                        default:
                            throw new Exception(String.Format("Rxop command type \"{0}\" not supported!", commandType.ToString()));
                    }

                    arguments.Append(" --lock-off ");

                    //Caso ssl habilitado
                    if (impressoraInfo.SslActive)
                        arguments.Append(" --ssl-certless ");
                    //Caso tiver senha
                    if (!String.IsNullOrEmpty(impressoraInfo.DsPassword))
                        arguments.Append(" --password-device " + impressoraInfo.DsPassword);

                    p.StartInfo.Arguments = arguments.ToString();

                    p.Start();

                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();

                    p.WaitForExit();

                    if (_containsException)
                        throw new Exception("Verifique o erro apresentado");
                }
            }
            finally
            {
                if (tempDirPath != null && Directory.Exists(tempDirPath))
                    Directory.Delete(tempDirPath, true);
            }

        }



        /// <summary>
        /// Configures the URL of the REST services to be used within the Android solution.
        /// </summary>
        /// <param name="impressoraInfo">Object to configure embedded application</param>
        /// <returns>True if configuration request was successful, false if failed.</returns>
        private void SetupAndroidApp(EmbeddedParamsInfo impressoraInfo)
        {
            string protocol = "http://";

            if (impressoraInfo.SslActive)
            {
                protocol = "https://";
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                        delegate (object sender,
                                System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                                System.Security.Cryptography.X509Certificates.X509Chain chain,
                                System.Net.Security.SslPolicyErrors sslPolicyErrors)
                        {
                            return true; // **** Always accept
                        };
            }
            switch (impressoraInfo.Product)
            {
                case Product.SmartShare:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\Tracker\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276263";
                    break;
                case Product.SafePrint:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\SafePrint\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276261";
                    break;
                case Product.Tracker:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\Tracker\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276234";
                    break;
            }
            RestRequest request = new RestRequest("/rws/sop/" + ANDROID_EMBEDDED_CODE + "/remoteConfig", Method.Post);
            request.AddParameter("application/json; charset=utf-8", ParameterType.RequestBody);
            request.AddJsonBody(new { webServiceUrl = impressoraInfo.DsUrlWebService });
            RestClient client = new RestClient(protocol + impressoraInfo.DsIPMFP);

            LogEvent(string.Format("Start configuring the server. Please wait... "));
            ExecuteRequest(client, request);
        }

        private async Task ExecuteRequest(RestClient client, RestRequest request, int numberOfTries = 0)
        {
            numberOfTries++;
            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    LogEvent("Setup Android App is done!");
                }
                else
                {
                    if (numberOfTries < MAX_NUM_TRIES)
                    {
                        LogEvent(string.Format("Setup Android App: Request to {0} {1} | Response Status [{2}]. If the device is restarting, this message is normal. Please wait...", request.Resource, response.StatusCode));
                        await Task.Delay(10000);
                        await ExecuteRequest(client, request, numberOfTries);
                    }
                    else
                    {
                        LogEvent("Something went wrong during the configuration process. Please, contact the System Administrator");
                    }
                }
            }
            catch (Exception ex)
            {
                LogEvent($"Exception: {ex.Message}");
                throw;
            }
        }
        public void validateComany(EmbeddedParamsInfo impressoraInfo)
        {
            switch (impressoraInfo.Product)
            {
                case Product.SmartShare:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\Tracker\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276263";
                    break;
                case Product.SafePrint:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\SafePrint\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276261";
                    break;
                case Product.Tracker:
                    EMBEDDED_BASE_DIRECTORY = @"Embedded\Tracker\RICOH\";
                    ANDROID_EMBEDDED_CODE = "1711276234";
                    break;
            }
        }
    }
}
