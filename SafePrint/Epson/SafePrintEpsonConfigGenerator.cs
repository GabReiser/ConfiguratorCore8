using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ConfiguratorNewest.SafePrint.Epson
{
    public class SafePrintConfigGenerator
    {
        public string generateJsonConfig(string ipSafePrintServer, bool devMode, bool hasScanToMe)
        {
            var remoteConfig = new EpsonRemoteConfig
            {
                webServiceUrl = "http://" + ipSafePrintServer + "/webapisafeprint/api/v1/safeprint/",
                devMode = devMode,
                hasScanToMe = hasScanToMe
            };
            SafePrintEpsonConfigurations safePrintConfig;
            {
                var smbConfig = new EpsonSMBConfig
                {
                    domain = "",
                    destination = "",
                    account = "",
                    password = "",
                    maxSizeFile = 0
                };
                safePrintConfig = new SafePrintEpsonConfigurations
                {
                    remoteConfig = remoteConfig,
                    smbConfig = smbConfig
                };
            }

            return JsonConvert.SerializeObject(safePrintConfig, Formatting.Indented);
        }
        public string generateJsonConfigWithScanToMe(string ipSafePrintServer, bool devMode, bool hasScanToMe, string domain, string destination, string account, string password, int maxSizeFile)
        {
            var remoteConfig = new EpsonRemoteConfig
            {
                webServiceUrl = "http://" + ipSafePrintServer + "/webapisafeprint/api/v1/safeprint/",
                devMode = devMode,
                hasScanToMe = hasScanToMe
            };
            SafePrintEpsonConfigurations safePrintConfig;
            {
                var smbConfig = new EpsonSMBConfig
                {
                    domain = domain,
                    destination = destination,
                    account = account,
                    password = password,
                    maxSizeFile = maxSizeFile
                };
                safePrintConfig = new SafePrintEpsonConfigurations
                {
                    remoteConfig = remoteConfig,
                    smbConfig = smbConfig
                };
            }
            return JsonConvert.SerializeObject(safePrintConfig, Formatting.Indented);
        }

    }
}
