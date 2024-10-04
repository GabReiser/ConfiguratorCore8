using ConfiguratorNewest.BLL;
using ConfiguratorNewest.Enum;
using ConfiguratorNewest.Instalation.Ricoh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace ConfiguratorNewest.Forms
{
    public partial class InstalarSafePrint : Form
    {
        #region Properties
        delegate void FillLogComponent(String msg);
        private static readonly EmbeddedManagement embeddedCore = new EmbeddedManagement();
        private ActionType action;
        #endregion

        private static readonly string SERVICE_PORT = " --server.port=";

        #region Constructor
        public InstalarSafePrint()
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            ManagementRICOH.OnLogEvent += ManagementRICOH_OnLogEvent;
            try
            {
                string actionS = (sender as Button).Text.ToLower();
                action = actionS.Equals("instalar") ? ActionType.Install : ActionType.Uninstall;

                EmbeddedParamsInfo info = createEmbeddedParamsInfo();

                if (info.Validate(action))
                {

                    DialogResult dr = MessageBox.Show(String.Format("Confirma {0} o Software Embarcado SmartShare no equipamento com IP:{1}?", actionS, info.DsIPMFP), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            ProccessAction(info);
                            //progressBar1.Value = 100;
                        }).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage(String.Concat("ERROR: ", ex.Message));

                DisableEnableAll(true);
                LogMessage("Finished.");
                progressBar1.Value = 100;
                this.Refresh();
            }
        }

        private void LogMessage(String msg)
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;

            txtLog.SelectionColor = EmbeddedBLL.ChoiceColor(msg);

            ValidateProgressPerMessage(msg);

            if (!String.IsNullOrEmpty(msg)) txtLog.AppendText(String.Format("{0} {1} {2}", DateTime.Now.ToString("T"), msg, Environment.NewLine));

            txtLog.SelectionColor = txtLog.ForeColor;

            txtLog.SelectionStart = txtLog.Text.Length;
            try
            {
                txtLog.ScrollToCaret();
                this.Refresh();
            }
            catch (Exception) { }
        }


        private void ValidateProgressPerMessage(String msg)
        {
            if (!String.IsNullOrEmpty(msg))
            {
                if (msg.ToUpper().Contains("STATE_GET_APP_INFO_START") && progressBar1.Value < 100) progressBar1.Value = 10;
                if (msg.ToUpper().Contains("STATE_GET_APP_INFO_END") && progressBar1.Value < 100) progressBar1.Value = 20;
                if (msg.ToUpper().Contains("STATE_STOP_APP_START") && progressBar1.Value < 100) progressBar1.Value = 30;
                if (msg.ToUpper().Contains("STATE_STOP_APP_END") && progressBar1.Value < 100) progressBar1.Value = 40;

                if (action == ActionType.Install)
                {
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_START") && progressBar1.Value < 100) progressBar1.Value = 50;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_END") && progressBar1.Value < 100) progressBar1.Value = 60;
                    if (msg.ToUpper().Contains("STATE_INSTALL_START") && progressBar1.Value < 50) progressBar1.Value = 70;
                    if (msg.ToUpper().Contains("STATE_INSTALL_END") && progressBar1.Value < 50) progressBar1.Value = 80;
                    if (msg.ToUpper().Contains("STATE_REBOOT_START") && progressBar1.Value < 100) progressBar1.Value = 90;
                    if (msg.ToUpper().Contains("STATE_REBOOT_WAIT") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("PLEASE WAIT") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("SETUP ANDROID APP IS DONE!") && progressBar1.Value <= 100) progressBar1.Value = 100;

                }
                if (action == ActionType.Uninstall)
                {
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_START") && progressBar1.Value < 100) progressBar1.Value = 80;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_COMMIT") && progressBar1.Value < 50) progressBar1.Value = 90;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_END") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("REBOOT_END") && progressBar1.Value < 100) progressBar1.Value = 100;
                }

                this.Refresh();
                progressBar1.Refresh();
            }
        }
        private void ProccessAction(EmbeddedParamsInfo info)
        {
            DisableEnableAll(false);
            progressBar1.Value = 0;
            SafeInvoke(() => this.Refresh());

            ClearLog();
            LogMessage("Starting...");

            try
            {
                if (action == ActionType.Install)
                    embeddedCore.Install(info, Company.Ricoh, false);
                else
                    embeddedCore.Uninstall(info, Company.Ricoh);
            }
            catch (HttpRequestException e)
            {
                LogMessage(string.Format("Url is invalid. " + e.Message));
            }
            catch (Exception e)
            {
                LogMessage(string.Format(
                    "Something went wrong during the configuration process. Please, contact the System Administrator. " + e.Message));
            }
            finally
            {
                DisableEnableAll(true);
                LogMessage("Finished.");
                progressBar1.Value = 100;
                SafeInvoke(() => this.Refresh());
            }
        }

        private void SafeInvoke(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void ManagementRICOH_OnLogEvent(object sender, CustomEventArgs e)
        {
            FillLogComponent logCom = new FillLogComponent(LogMessage);

            if (this.InvokeRequired)
                logCom.Invoke(e.Message);
            else
                LogMessage(e.Message);
        }

        private EmbeddedParamsInfo createEmbeddedParamsInfo()
        {
            EmbeddedParamsInfo info = new EmbeddedParamsInfo()
            {
                DsUrlWebService = txtWsDest.Text,
                DsIPMFP = txtIpMFP.Text,
                DsPassword = txtPassword.Text,
                DsUser = txtUser.Text,
                SslActive = checkBoxSsl.Checked
            };

            return info;
        }

        private void DisableEnableAll(bool isEnable)
        {
            btnInstall.Enabled = isEnable;
            btnUninstall.Enabled = isEnable;
            txtWsDest.Enabled = isEnable;
            txtIpMFP.Enabled = isEnable;
            txtLog.ReadOnly = isEnable;

            EnableMultipleInstall(isEnable);
        }
        private void EnableMultipleInstall(bool isEnable)
        {
            EmbeddedParamsInfo info = createEmbeddedParamsInfo();

            if (info.Validate(action))
            {
                btnInstallLote.Enabled = true;
            }
            else
            {
                btnInstallLote.Enabled = false;
            }

        }
        private void ClearLog()
        {
            txtLog.Text = String.Empty;
        }
        private string getIpAddress()
        {
            String strHostName = string.Empty;
            //IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress[] addr = ipEntry.AddressList;
            //if (addr.Length > 0)
            //{
            //    strHostName = addr[0].ToString();
            //}
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    strHostName = ip.ToString();
                }
            }
            return strHostName;
        }
        public static void RelaunchIfNotAdmin()
        {
            if (!RunningAsAdmin())
            {
                MessageBox.Show("Este programa precisa ser executado com privilégios de administrador !");
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Assembly.GetEntryAssembly().CodeBase;
                proc.Verb = "runas";
                try
                {
                    Process.Start(proc);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Este programa precisa ser executado com privilégios de administrador ! \n\n" + ex.ToString());
                    Environment.Exit(0);
                }
            }
        }

        private static bool RunningAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void InstalarSafePrint_Load(object sender, EventArgs e)
        {
            RelaunchIfNotAdmin(); // the app must be opened as admin

            //FormLoad();
            //lblVersion.Text = "Versão " + Application.ProductVersion;
            //rdRicohMfp.Checked = true;
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
            safeKyocera.Enabled = false;
            safeEpson.Enabled = false;
            safeXerox.Enabled = false;
            safeRicoh.Checked = true;
        }
    }


}
