using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAroundTheWorld.Startup))]
namespace MvcAroundTheWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
