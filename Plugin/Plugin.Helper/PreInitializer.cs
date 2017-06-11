using Plugin.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Compilation;

[assembly: PreApplicationStartMethod(typeof(Plugin.Helper.PreInitializer), "Initialize")]

namespace Plugin.Helper
{

    public class PreInitializer
    {
        public static void Initialize()
        {
            PluginHelper.Instance.Modules.Clear();
            string folderPath = $"{AppDomain.CurrentDomain.BaseDirectory}Plugin";
            string[] files = Directory.GetFiles(folderPath, "*.dll");

            foreach (var filePath in files)
            {
                var loadAssembly = Assembly.LoadFile(filePath);
                var pluginTypes = loadAssembly.GetTypes().Where(x => typeof(IPlugin).IsAssignableFrom(x));

                foreach (var pluginType in pluginTypes)
                {
                    var plugin = Activator.CreateInstance(pluginType);
                    PluginHelper.Instance.Modules.Add((IPlugin)plugin, loadAssembly);

                    if (_AddReference)
                        BuildManager.AddReferencedAssembly(loadAssembly);
                }
            }
        }

        private static bool _AddReference = true;
        public static bool AddReference
        {
            get { return _AddReference; }
            set { _AddReference = value; }
        }
    }
}
