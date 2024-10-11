using ConfiguratorNewest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Epson
{
    public class SendEpsonConfig
    {
        public SafePrintEpsonConfig SafePrintEpsonConfig { get; set; }
        public SafePrintEpsonConfigurations SafePrintConfig { get; set; }
        public EpsonSMBConfig SMBConfig { get; set; }

        private readonly ILoggerService _logger;
        public SendEpsonConfig(ILoggerService logger)
        {
            _logger = logger;
        }

        public void sendConfigToEpson()
        {
            _logger.LogInformation("----------- ENVIO PARA EPSON ---------------");
            StringUtils stringUtils = new StringUtils();
            SafePrintConfigGenerator safePrintConfigGenerator = new SafePrintConfigGenerator();
            bool hasScanToMe = SafePrintEpsonConfig.getHasScanToMe();
            string jsonBody;
            if (hasScanToMe)
            {
                var pwd = SafePrintEpsonConfig.ScanToMeEpson.getPassword();
                var pwdCrypted = stringUtils.Crypt(pwd);
                jsonBody = safePrintConfigGenerator.generateJsonConfigWithScanToMe(
                    SafePrintEpsonConfig.getIpSafePrintServer(),
                    SafePrintEpsonConfig.devMode,
                    true,
                    SafePrintEpsonConfig.ScanToMeEpson.getDomain(),
                    SafePrintEpsonConfig.ScanToMeEpson.getDestination(),
                    SafePrintEpsonConfig.ScanToMeEpson.getAccount(),
                    pwdCrypted,
                    SafePrintEpsonConfig.ScanToMeEpson.getMaxSize());
                _logger.LogInformation("ScanToMe habilitado");
                _logger.LogDebug(jsonBody);
            }
            else
            {

                jsonBody = safePrintConfigGenerator.generateJsonConfig(
                    SafePrintEpsonConfig.getIpSafePrintServer(),
                    SafePrintEpsonConfig.devMode,
                    false);
                _logger.LogInformation("ScanToMe não habilitado");
                _logger.LogDebug(jsonBody);
            }

            string endPoint = "http://" + SafePrintEpsonConfig.getIpServerService()
                + ":8090/service/safeprint/config/remoteConfig";
            _logger.LogInformation(endPoint);
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(endPoint, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    //progress.Report(100);
                    _logger.LogInformation($"{response.StatusCode} - Requisição POST bem-sucedida! /nDetalhes:{response.Content}");
                    MessageBox.Show("Sucesso ao enviar a configuração", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _logger.LogInformation($"Falha na requisição POST. Status:{response.StatusCode}");
                }
            }
        }
    }
}
