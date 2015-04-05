using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TKMobileStore.Web.Startup))]
namespace TKMobileStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
