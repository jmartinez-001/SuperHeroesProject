using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHeroesWebApp2.Startup))]
namespace SuperHeroesWebApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
