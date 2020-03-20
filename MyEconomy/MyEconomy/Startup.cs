using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEconomy.Startup))]
namespace MyEconomy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
