using Plugin.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Helper
{
    internal class PluginHelper
    {
        public PluginHelper()
        {
            Modules = new Dictionary<IPlugin, Assembly>();
        }

        private static PluginHelper _Instance = null;

        public static PluginHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PluginHelper();

                return _Instance;
            }
        }
        
        public List<IPlugin> Plugins
        {
            get
            {
                return Modules.Keys.ToList();
            }
        }

        internal Dictionary<IPlugin, Assembly> Modules { get; set; }
    }
}
