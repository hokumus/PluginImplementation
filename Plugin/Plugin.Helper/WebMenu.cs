using Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Helper
{
    public class WebMenu : PluginMenu
    {
        public WebMenu()
        {
            Plugins = new List<IPlugin>();
        }

        public List<IPlugin> Plugins { get; private set; }
    }
}
