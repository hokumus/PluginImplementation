using Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.HumanResource.MVC
{
    public class HumanResource : IPlugin
    {
        public string ActionName
        {
            get
            {
                return "Index";
            }
        }

        public string ControllerName
        {
            get
            {
                return "Human";
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
