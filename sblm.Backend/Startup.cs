using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sblm.Backend.Startup))]
namespace sblm.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
