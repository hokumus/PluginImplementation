using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Core
{
    public interface IPlugin
    {
        string MenuTitle { get; }
        string ActionName { get; }
        string ControllerName { get; }
        List<string> Menu { get; }
    }
}
