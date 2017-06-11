using Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.Helper
{
    public class WinMenuCreator : Creator
    {
        public override PluginMenu Create()
        {
            PreInitializer.AddReference = false;
            PreInitializer.Initialize();
            WinMenu menu = new WinMenu();
            ToolStripMenuItem menuItem = null;

            foreach (var item in PluginHelper.Instance.Plugins)
            {
                menuItem = new ToolStripMenuItem();
                menuItem.Text = item.MenuTitle;

                if (item.Menu != null)
                {
                    foreach (var subItem in item.Menu)
                    {
                        ToolStripMenuItem subMenuItem = new ToolStripMenuItem();
                        subMenuItem.Text = subItem;

                        menuItem.DropDownItems.Add(subMenuItem);
                    }
                }

                menu.Items.Add(menuItem);
            }

            return menu;
        }
    }
}
