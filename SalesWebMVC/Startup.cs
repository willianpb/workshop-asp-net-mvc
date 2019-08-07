using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesWebMVC.Startup))]
namespace SalesWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
