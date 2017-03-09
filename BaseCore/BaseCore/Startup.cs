using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseCore.Startup))]
namespace BaseCore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
