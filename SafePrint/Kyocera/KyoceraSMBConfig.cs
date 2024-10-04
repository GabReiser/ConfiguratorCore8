using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.SafePrint.Kyocera
{
    public class KyoceraSMBConfig
    {
        public string port { get; set; }
        public string directory { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public int maxSizeFile { get; set; }
    }
}
