using Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.HumanResource.Win
{
    public class HumanResource : IPlugin
    {
        public string ActionName
        {
            get
            {
                return string.Empty;
            }
        }

        public string ControllerName
        {
            get
            {
                return string.Empty;
            }
        }

        public List<string> Menu
        {
            get
            {
                return new List<string> { "Emploies", "Recruitment" };
            }
        }

        public string MenuTitle
        {
            get
            {
                return "Human Resources";
            }
        }
    }
}
