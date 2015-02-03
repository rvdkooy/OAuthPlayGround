using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApp1.Startup))]
namespace MvcApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
