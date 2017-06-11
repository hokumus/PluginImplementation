using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plugin.WebUI.Startup))]
namespace Plugin.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
