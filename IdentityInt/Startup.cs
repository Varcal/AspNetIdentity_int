using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityInt.Startup))]
namespace IdentityInt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
