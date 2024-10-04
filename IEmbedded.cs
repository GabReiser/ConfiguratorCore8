using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest
{
    public interface IEmbedded
    {
        void Install(EmbeddedParamsInfo info, bool isConfigurate);
        void Uninstall(EmbeddedParamsInfo info);
    }
}
