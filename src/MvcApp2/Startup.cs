using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApp2.Startup))]
namespace MvcApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
