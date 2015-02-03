using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBluesCorp.Startup))]
namespace TheBluesCorp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
