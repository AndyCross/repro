using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(repro.web.Startup))]
namespace repro.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
