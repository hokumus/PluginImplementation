using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.Helper
{
    public class WinMenu : PluginMenu
    {
        public WinMenu()
        {
            this.Items = new List<ToolStripMenuItem>();
        }

        public List<ToolStripMenuItem> Items { get; set; }
    }
}
