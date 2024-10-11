using System.Diagnostics;
using System.IO.Compression;


namespace ConfiguratorNewest.SmartShare.Epson
{
    public class InstallServiceEpsonShare
    {
        public void InstallServiceEpson()
        {
            // Verifica se o Java está instalado
            if (!IsJavaInstalled())
            {
                Console.WriteLine("Java não está instalado.");
                return;
            }

            // Extrai e move os arquivos necessários
            ExtractAndMoveFiles();

            // Copia os arquivos para o diretório de destino
            CopyFiles();

            // Instala o serviço
            InstallService();
        }   
        public void ExtractAndMoveFiles()
        {
            // Caminho do arquivo ZIP e diretório de destino
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string zipPath = Path.Combine(baseDirectory, "Embedded", "EPSON", "SmartShare", "smartshare-app.zip");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao extrair arquivos: {ex.Message}");
            }
        }
        public void CopyFiles()
        {
            // Caminho da pasta de origem e diretório de destino
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sourceDirectory = Path.Combine(baseDirectory, "Embedded", "EPSON", "SmartShare");
            string destinationPath = @"C:\SmartShareEpson-Embedded";

            try
            {
                // Verifica se o diretório de destino para os arquivos copiados existe, se não, cria
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }

                // Lista de arquivos a serem copiados
                string[] filesToCopy = { "epson-smartshare-service.exe", "epson-smartshare-service.jar", "epson-smartshare-service.xml" };

                foreach (var fileName in filesToCopy)
                {
                    string sourceFile = Path.Combine(sourceDirectory, fileName);
                    string destFile = Path.Combine(destinationPath, fileName);

                    if (File.Exists(sourceFile))
                    {
                        File.Copy(sourceFile, destFile, true);
                        Console.WriteLine($"Arquivo {fileName} copiado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"Arquivo {fileName} não encontrado para copiar.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao copiar arquivos: {ex.Message}");
            }
        }
        public void InstallService()
        {
            string destinationPath = @"C:\SmartShareEpson-Embedded";
            string exePath = Path.Combine(destinationPath, "epson-smartshare.exe");

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

                    Console.WriteLine("Serviço instalado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Arquivo executável não encontrado para instalar o serviço.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao instalar o serviço: {ex.Message}");
            }
        }
        public bool IsJavaInstalled()
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
                        return result.Contains("version");
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
