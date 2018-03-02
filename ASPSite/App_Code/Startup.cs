using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPSite.Startup))]
namespace ASPSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
