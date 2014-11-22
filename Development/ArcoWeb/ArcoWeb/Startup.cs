using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArcoWeb.Startup))]
namespace ArcoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
