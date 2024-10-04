using ConfiguratorNewest.Utils;

namespace ConfiguratorNewest.SafePrint.Kyocera
{
    public class SendKyoceraConfig

    {
        public SafePrintKyoceraConfig SafePrintKyoceraConfig { get; set; }
        public SafePrintKyoceraConfigurations kyoceraConfigurations { get; set; }
        public KyoceraSMBConfig SMBConfig { get; set; }
        public ScanToMeKyocera ScanToMeKyocera { get; set; }

        private readonly ILoggerService _logger;
        public SendKyoceraConfig(ILoggerService logger)
        {
            _logger = logger;
        }
        public void sendConfigToKyoceraAsync()
        {
            try
            {
                _logger.LogInformation("----------- ENVIO PARA KYOCERA ---------------");
                string printerIp = SafePrintKyoceraConfig.getIpPrinter();
                int port = 8080;
                string servletPath = "SafePrint/servlet/settings.do";

                //webServiceUrl = "http://" + ipSafePrintServer + "/safeprint/webservices/SafePrint.asmx",
                var queryParams = new Dictionary<string, string>
                {
                    { "cmd", "config" },
                    { "ipDevice", SafePrintKyoceraConfig.getIpPrinter() },
                    { "urlSafePrint", "http://" + SafePrintKyoceraConfig.getIpSafePrintServer() + "/safeprint/webservices/SafePrint.asmx"},
                    { "isSecureConnection", "false"},
                    { "isEnabledScanToMe", SafePrintKyoceraConfig.getHasScanToMe().ToString()}
                    //{ "isSecureConnection", SafePrintKyoceraConfig.getIsSecureConnection()} CRIAR O CHECKBOX PARA VALIDAR SE É HTTP OU HTTPS
                };

                if (SafePrintKyoceraConfig.getHasScanToMe())
                {
                    StringUtils stringUtils = new StringUtils();
                    var pwdCrypted = stringUtils.Crypt(SafePrintKyoceraConfig.ScanToMeKyocera.getPassword());
                    var userCrypted = stringUtils.Crypt(SafePrintKyoceraConfig.ScanToMeKyocera.getUser());
                    queryParams.Add("server", SafePrintKyoceraConfig.getIpSafePrintServer());
                    queryParams.Add("port", SafePrintKyoceraConfig.ScanToMeKyocera.getPort());
                    queryParams.Add("login", userCrypted);
                    queryParams.Add("password", pwdCrypted);
                    queryParams.Add("path", SafePrintKyoceraConfig.ScanToMeKyocera.getDirectory());
                    queryParams.Add("maxSize", SafePrintKyoceraConfig.ScanToMeKyocera.getMaxSize().ToString());
                }

                string urlWithParams = BuildUrlWithParams(printerIp, port, servletPath, queryParams);
                _logger.LogInformation("queryString: " + urlWithParams);
                using (HttpClient client = new HttpClient())
                {
                    _logger.LogInformation("Enviando a requisição para o equipamento...");
                    HttpResponseMessage response = client.GetAsync(urlWithParams).Result;
                    response.EnsureSuccessStatusCode();
                    //string responseBody = response.Content.ReadAsStringAsync();
                    _logger.LogInformation("Requisição enviada com sucesso: " + response.StatusCode);
                    //progress.Report(100); // Indicar que a operação foi concluída
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError("Ocorreu um erro ao enviar a requisição: " + ex.Message);
            }
        }
        private static string BuildUrlWithParams(string ip, int port, string path, Dictionary<string, string> queryParams)
        {
            var query = new List<string>();

            foreach (var param in queryParams)
            {
                query.Add($"{param.Key}={param.Value}");
            }

            return $"http://{ip}:{port}/{path}?" + string.Join("&", query);
        }

    }
}
