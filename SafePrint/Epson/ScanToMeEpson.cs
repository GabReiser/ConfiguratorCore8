using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Epson
{
    public class ScanToMeEpson
    {
        public string account;
        public string password;
        public int maxSize;
        public string domain;
        public string destination;

        public void setAccount(string account)
        {
            this.account = account;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setDomain(string domain)
        {
            this.domain = domain;
        }
        public void setDestination(string destination)
        {
            this.destination = destination;
        }
        public void setMaxSize(int maxSize)
        {
            this.maxSize = maxSize;
        }

        public string getAccount()
        {
            return this.account;
        }
        public string getPassword()
        {
            return this.password;

        }
        public string getDomain()
        {
            return this.domain;
        }
        public string getDestination()
        {
            return this.destination;
        }
        public int getMaxSize()
        {
            return this.maxSize;
        }
    }
}
