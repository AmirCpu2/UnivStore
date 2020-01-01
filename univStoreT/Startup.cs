using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(univStoreT.Startup))]
namespace univStoreT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
