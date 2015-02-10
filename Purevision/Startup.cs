using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Purevision.Startup))]
namespace Purevision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}