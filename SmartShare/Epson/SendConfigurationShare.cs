using Newtonsoft.Json;
using System.Text;

namespace ConfiguratorNewest.SmartShare.Epson
{
    public class SendConfigurationShare
    {
        public void SendConfigurationAsync(string ipServidor, string wsShare, bool devMode)
        {
            // Register the code pages encoding provider
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            object jsonData;
            if (devMode)
            {
                jsonData = new
                {
                    webServiceUrl = wsShare,
                    isDevMode = true
                };
            }
            jsonData = new
            {
                webServiceUrl = wsShare,
                isDevMode = false
            };
            var jsonString = JsonConvert.SerializeObject(jsonData);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // URL do servidor
            var url = $"http://{ipServidor}:8091/service/smartshare/config/remoteConfig";
            using (var client = new HttpClient())
            {
                try
                {
                    var response = client.PostAsync(url, content).GetAwaiter().GetResult();
                    response.EnsureSuccessStatusCode();
                    Console.WriteLine("Configuração enviada com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao enviar configuração: {ex.Message}");
                }
            }
        }
    }
}
