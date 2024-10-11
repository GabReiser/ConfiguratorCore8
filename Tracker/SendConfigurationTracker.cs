using Newtonsoft.Json;
using System.Text;

namespace ConfiguratorNewest.Tracker
{
    public class SendConfigurationTracker
    {
        public void SendConfiguration(string ipServidor, string wsTracker, bool devMode, bool hasScanToMe)
        {
            // Register the code pages encoding provider
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Object jsonData;
            wsTracker = $"http://{wsTracker}:64655/RPortalService/";
            if (devMode)
            {
                jsonData = new
                {
                    webServiceUrl = wsTracker,
                    isDevMode = true,
                    hasScanToMe = hasScanToMe
                };
            }
            jsonData = new
            {
                webServiceUrl = wsTracker,
                isDevMode = false,
                hasScanToMe = hasScanToMe
            };
            var jsonString = JsonConvert.SerializeObject(jsonData);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // URL do servidor
            var url = $"http://{ipServidor}:8088/service/tracker/config/remoteConfig";
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
