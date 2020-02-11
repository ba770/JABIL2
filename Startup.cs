using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JABIL2.Startup))]
namespace JABIL2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
