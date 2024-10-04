using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Kyocera
{
    public class ScanToMeKyocera
    {
        public string user;
        public string password;
        public int maxSize;
        public string port;
        public string directory;

        public void setAccount(string user)
        {
            this.user = user;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setPort(string port)
        {
            this.port = port;
        }
        public void setDirectory(string directory)
        {
            this.directory = directory;
        }
        public void setMaxSize(int maxSize)
        {
            this.maxSize = maxSize;
        }

        public string getUser()
        {
            return this.user;
        }
        public string getPassword()
        {
            return this.password;

        }
        public string getPort()
        {
            return this.port;
        }
        public string getDirectory()
        {
            return this.directory;
        }
        public int getMaxSize()
        {
            return this.maxSize;
        }
    }
}
