using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLab.Startup))]
namespace WebLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
