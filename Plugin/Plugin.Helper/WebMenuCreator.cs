using Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Helper
{
    public class WebMenuCreator : Creator
    {
        public override PluginMenu Create()
        {
            WebMenu menu = new WebMenu();            
            menu.Plugins.AddRange(PluginHelper.Instance.Plugins);

            return menu;
        }
    }
}
