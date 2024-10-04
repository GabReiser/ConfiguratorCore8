using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest.Enum
{
    public enum RxopCommandType
    {
        [Description("install")]
        INSTALL,
        [Description("install-start")]
        INSTALL_START,
        [Description("uninstall")]
        UNINSTALL,
        [Description("stop-uninstall")]
        STOP_UNINSTALL,
        [Description("reboot")]
        REBOOT,
        [Description("priority")]
        SET_PRIORITY,
        [Description("get-apps-less")]
        GET_APPS_LESS
    }
}
