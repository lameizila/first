using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1351300303.Startup))]
namespace _1351300303
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
