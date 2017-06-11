using Plugin.Core;
using Plugin.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadMenu_Click(object sender, EventArgs e)
        {
            Creator creator = new WinMenuCreator();
            PluginMenu menu = creator.Create();

            foreach (var item in ((WinMenu)menu).Items)
            {
                menuStrip.Items.Insert(0, item);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
