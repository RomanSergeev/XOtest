using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XO.Startup))]
namespace XO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
