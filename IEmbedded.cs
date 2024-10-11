using ConfiguratorNewest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest
{
    public interface IEmbedded
    {
        void Install(EmbeddedParamsInfo info, bool isConfigurate, Company company);
        void Uninstall(EmbeddedParamsInfo info, Company company);
    }
}
