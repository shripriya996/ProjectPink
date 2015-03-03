using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectPink.Startup))]
namespace ProjectPink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
