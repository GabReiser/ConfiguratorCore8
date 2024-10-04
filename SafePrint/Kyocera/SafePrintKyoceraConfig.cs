using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Kyocera
{
    public class SafePrintKyoceraConfig
    {
        public string ipPrinter;
        public bool devMode;
        public string ipSafePrintServer;
        public bool hasScanToMe;
        public string isSecureConnection;
        public ScanToMeKyocera ScanToMeKyocera { get; set; }
        public void setIsSecureConnection(string isSecureconnection) { this.isSecureConnection = isSecureconnection; }
        public string getIsSecureConnection() { return isSecureConnection; }
        public void setIpPrinter(string ipServerService) { this.ipPrinter = ipServerService; }
        public string getIpPrinter() { return this.ipPrinter; }
        public void setIpSafePrintServer(string ipSafePrintServer) { this.ipSafePrintServer = ipSafePrintServer; }
        public string getIpSafePrintServer() { return this.ipSafePrintServer; }
        public bool getHasScanToMe() { return this.hasScanToMe; }
        public void setHasScanToMe(bool hasScanToMe) { this.hasScanToMe = hasScanToMe; }
        public bool getDevMode() { return devMode = false; }
    }
}
