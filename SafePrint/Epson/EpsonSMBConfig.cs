using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Epson
{
    public class EpsonSMBConfig
    {
        public string domain { get; set; }
        public string destination { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public int maxSizeFile { get; set; }

    }
}
