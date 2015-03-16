using Autofac;
using Microsoft.Owin;
using Owin;
using Tinder4Jobs.Data.Infrastructure;
using Tinder4Jobs.Data.Repository;
using Tinder4Jobs.Web.Mappings;
using Tinder4Jobs.Services;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Reflection;
using Tinder4Jobs.Web.App_Start;

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
