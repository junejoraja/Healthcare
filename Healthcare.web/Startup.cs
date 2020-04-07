using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Healthcare.web.Startup))]
namespace Healthcare.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
