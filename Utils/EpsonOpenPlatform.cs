using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.Utils
{
    public class ProductKey
    {
        public string Key { get; set; }
    }

    public class ServerSettings
    {
        public string InitialWebPageURL { get; set; }
        public string RepresentativeWebPageURL { get; set; }
        public string AccessToken { get; set; }
        public string NotificationURL { get; set; }
        public int NotificationTimeout { get; set; }
        public string IconName { get; set; }
    }

    public class ServerConnection
    {
        public List<ServerSettings> ServerSettings { get; set; }
        public int VerifyCertForBrowser { get; set; }
        public int EnableQuotaManagement { get; set; }
        public string DeviceConfigTag { get; set; }
        public int LogLimitOperation { get; set; }
    }

    public class OpenPlatformSettings
    {
        public ProductKey ProductKey { get; set; }
        public ServerConnection ServerConnection { get; set; }
    }

    public class Configuration
    {
        public OpenPlatformSettings OpenPlatformSettings { get; set; }
    }
}
