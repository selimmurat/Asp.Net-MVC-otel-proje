using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Otel.Startup))]
namespace Otel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
