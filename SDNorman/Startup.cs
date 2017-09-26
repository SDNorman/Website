using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDNorman.Startup))]
namespace SDNorman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
