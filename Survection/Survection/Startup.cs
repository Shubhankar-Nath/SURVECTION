using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Survection.Startup))]
namespace Survection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
