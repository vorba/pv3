using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Purevision.Web.Startup))]
namespace Purevision.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}