using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DietTime.Startup))]
namespace DietTime
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
