using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaglikUrunleri.PL.MVC.Startup))]
namespace SaglikUrunleri.PL.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
