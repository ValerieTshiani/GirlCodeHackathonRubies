using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RubiesGirlCodeHackathon.Startup))]
namespace RubiesGirlCodeHackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
