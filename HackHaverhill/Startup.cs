using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackHaverhill.Startup))]
namespace HackHaverhill
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
