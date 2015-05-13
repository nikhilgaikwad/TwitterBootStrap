using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapExample.Startup))]
namespace BootStrapExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
