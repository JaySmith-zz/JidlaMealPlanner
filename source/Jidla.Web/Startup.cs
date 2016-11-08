using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jidla.Web.Startup))]
namespace Jidla.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
