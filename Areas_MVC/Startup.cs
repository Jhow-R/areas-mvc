using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Areas_MVC.Startup))]
namespace Areas_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
