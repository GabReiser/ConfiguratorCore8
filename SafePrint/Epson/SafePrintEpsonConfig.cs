using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Epson
{
    public class SafePrintEpsonConfig
    {
        public string ipServerService;
        public bool devMode;
        public string ipSafePrintServer;
        public bool hasScanToMe;
        public ScanToMeEpson ScanToMeEpson { get; set; }

        public void setIpServerService(string ipServerService)
        {
            this.ipServerService = ipServerService;
        }
        public string getIpServerService()
        {
            return this.ipServerService;
        }
        public void setIpSafePrintServer(string ipSafePrintServer)
        {
            this.ipSafePrintServer = ipSafePrintServer;
        }
        public string getIpSafePrintServer()
        {
            return this.ipSafePrintServer;
        }
        public bool getHasScanToMe() { return this.hasScanToMe; }
        public void setHasScanToMe(bool hasScanToMe) { this.hasScanToMe = hasScanToMe; }
        public bool getDevMode()
        {
            return devMode = false;
        }

    }
}
