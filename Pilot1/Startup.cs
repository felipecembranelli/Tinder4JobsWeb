using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pilot1.Startup))]
namespace Pilot1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
