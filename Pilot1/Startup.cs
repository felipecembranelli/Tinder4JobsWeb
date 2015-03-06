using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tinder4Jobs.Web.Startup))]
namespace Tinder4Jobs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
