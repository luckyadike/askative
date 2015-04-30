using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(askative.Startup))]
namespace askative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
