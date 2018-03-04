using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterApplication.Startup))]
namespace RegisterApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
