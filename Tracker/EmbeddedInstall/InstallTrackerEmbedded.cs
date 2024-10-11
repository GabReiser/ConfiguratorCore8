using ConfiguratorNewest.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.Tracker.EmbeddedInstall
{
    public class InstallTrackerEmbedded
    {
        public void InstallEmbeddedTracker(RichTextBox richTextBox, string productKey, string ipServidor, string ipImpressora, string senhaAdminMFP)
        {
            if (ValideteFields(productKey, ipServidor, ipImpressora, senhaAdminMFP))
            {
                LogTextBox(richTextBox, "Iniciando instalação do rastreador embarcado...");

                if (ConfigureEquipment(productKey, ipServidor, ipImpressora, senhaAdminMFP))
                {
                    LogTextBox(richTextBox, "Equipamento configurado com sucesso.");

                    if (InstallService(richTextBox))
                    {
                        LogTextBox(richTextBox, "Serviço instalado com sucesso.");
                        return;
                    }
                    else
                    {
                        LogTextBox(richTextBox, "Erro ao instalar serviço.");
                    }
                }
                else
                {
                    LogTextBox(richTextBox, "Erro ao configurar equipamento.");
                }
            }
            else
            {
                LogTextBox(richTextBox, "Preencha todos os campos.");
            }
        }
        public bool ConfigureEquipment(string productKey, string ipServidor, string ipImpressora, string senhaAdminMFP)
        {
            try
            {
                EpsonOpenPlatformConfigAsync(productKey, ipServidor, ipImpressora, senhaAdminMFP);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar equipamento: {ex.Message}");
                return false;
            }
        }
        private void LogTextBox(RichTextBox richTextBox, string message)
        {
            richTextBox.AppendText($"{DateTime.Now} - {message}\n");
        }

        private bool InstallService(RichTextBox richTextBox)
        {
            try
            {
                // Verifica se o Java está instalado
                if (!IsJavaInstalled(richTextBox))
                {
                    Console.WriteLine("Java não está instalado.");
                    return false;
                }

                // Extrai e move os arquivos necessários
                ExtractAndMoveFiles(richTextBox);

                // Copia os arquivos para o diretório de destino
                CopyFiles(richTextBox);

                // Instala o serviço
                InstallServiceOnPrimese(richTextBox);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao instalar serviço: {ex.Message}");
                return false;
            }
        }

        public void ExtractAndMoveFiles(RichTextBox richTextBox)
        {
            // Caminho do arquivo ZIP e diretório de destino
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string zipPath = Path.Combine(baseDirectory, "Embedded", "EPSON", "SmartShare", "tracker-app.zip");
            string extractPath = Path.Combine(@"C:\inetpub\wwwroot");

            try
            {
                // Verifica se o diretório de destino existe, se não, cria
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }

                // Extrai o arquivo ZIP para o diretório de destino
                ZipFile.ExtractToDirectory(zipPath, extractPath, true);

                Console.WriteLine("Arquivos extraídos com sucesso.");
                LogTextBox(richTextBox, "Arquivos extraídos com sucesso.");
            }
            catch (Exception ex)
            {
                LogTextBox(richTextBox, $"Erro ao extrair arquivos: {ex.Message}");
            }
        }
        public void CopyFiles(RichTextBox richTextBox)
        {
            // Caminho da pasta de origem e diretório de destino
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sourceDirectory = Path.Combine(baseDirectory, "Embedded", "EPSON", "Tracker");
            string destinationPath = @"C:\TrackerEpson-Embedded";
            LogTextBox(richTextBox, $"Copiando os arquivos para {destinationPath}.");

            try
            {
                // Verifica se o diretório de destino para os arquivos copiados existe, se não, cria
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }

                // Lista de arquivos a serem copiados
                string[] filesToCopy = { "epson-tracker-service.exe", "epson-tracker-service.jar", "epson-tracker-service.xml" };

                foreach (var fileName in filesToCopy)
                {
                    string sourceFile = Path.Combine(sourceDirectory, fileName);
                    string destFile = Path.Combine(destinationPath, fileName);

                    if (File.Exists(sourceFile))
                    {
                        File.Copy(sourceFile, destFile, true);
                        LogTextBox(richTextBox, $"Arquivo {fileName} copiado com sucesso.");
                    }
                    else
                    {
                        LogTextBox(richTextBox, $"Arquivo {fileName} não encontrado para copiar.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao copiar arquivos: {ex.Message}");
            }
        }
        public void InstallServiceOnPrimese(RichTextBox richTextBox)
        {
            string destinationPath = @"C:\TrackerEpson-Embedded";
            string exePath = Path.Combine(destinationPath, "epson-tracker-service.exe");

            try
            {
                if (File.Exists(exePath))
                {
                    // Comando para instalar o serviço
                    string command = $"/k {exePath} install service";

                    // Executa o comando usando o Process
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", command)
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WorkingDirectory = destinationPath
                    };

                    using (Process process = Process.Start(processInfo))
                    {
                        using (StreamReader reader = process.StandardOutput)
                        {
                            string result = reader.ReadToEnd();
                            Console.WriteLine(result);
                        }
                    }
                    LogTextBox(richTextBox, "Serviço instalado com sucesso.");
                }
                else
                {
                    LogTextBox(richTextBox, "Arquivo executável não encontrado para instalar o serviço.");
                }
            }
            catch (Exception ex)
            {
                LogTextBox(richTextBox, $"Erro ao instalar o serviço: {ex.Message}");
            }
        }
        public bool IsJavaInstalled(RichTextBox richTextBox)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("java", "-version")
                {
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processInfo))
                {
                    using (StreamReader reader = process.StandardError)
                    {
                        string result = reader.ReadToEnd();
                        if (result.Contains("version")) 
                        { 
                        LogTextBox(richTextBox, "Java encontrado.");
                        }
                        return result.Contains("version");
                    }
                }
            }
            catch
            {
                LogTextBox(richTextBox, "Java não encontrado.");
                return false;
            }
        }
        private string EpsonOpenPlatformConfigAsync(string productKey, string ipServidor, string ipImpressora, string senhaAdminMFP)
        {
            // Montar o objeto de configuração
            var config = new Configuration
            {
                OpenPlatformSettings = new OpenPlatformSettings
                {
                    ProductKey = new ProductKey { Key = productKey },
                    ServerConnection = new ServerConnection
                    {
                        ServerSettings = new List<ServerSettings>
                {
                    new ServerSettings
                    {
                        InitialWebPageURL = $"http://{ipServidor}/tracker-app/index.html",
                        RepresentativeWebPageURL = $"http://{ipServidor}/tracker-app/index.html",
                        AccessToken = "TrackerToken",
                        NotificationURL = $"http://{ipServidor}:8088/service/tracker/notifications",
                        NotificationTimeout = 10,
                        IconName = ""
                    },
                    new ServerSettings
                    {
                        InitialWebPageURL = "",
                        RepresentativeWebPageURL = "",
                        AccessToken = "",
                        NotificationURL = "",
                        NotificationTimeout = 10,
                        IconName = ""
                    }
                },
                        VerifyCertForBrowser = 0,
                        EnableQuotaManagement = 0,
                        DeviceConfigTag = "11111111-2222-3333-4444-555555555555",
                        LogLimitOperation = 0
                    }
                }
            };

            // Serializar o objeto em JSON
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);

            // URL de envio
            string url = $"http://{ipImpressora}/epsonhello/configure?admin_password={senhaAdminMFP}";

            // Enviar a requisição HTTP
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(url, content).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Configuração enviada com sucesso!");
                    return response.IsSuccessStatusCode.ToString();
                }
                else
                {
                    MessageBox.Show($"Erro ao enviar configuração: {response.ReasonPhrase}");
                    return response.ReasonPhrase;
                }
            }
        }
        private bool ValideteFields(string productKey, string ipServidor, string ipImpressora, string senhaAdminMFP)
        {
            if (string.IsNullOrEmpty(productKey) || string.IsNullOrEmpty(ipServidor) || string.IsNullOrEmpty(ipImpressora) || string.IsNullOrEmpty(senhaAdminMFP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
