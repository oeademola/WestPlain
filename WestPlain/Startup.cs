using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WestPlain.Startup))]
namespace WestPlain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
