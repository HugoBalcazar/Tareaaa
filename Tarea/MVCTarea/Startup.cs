using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTarea.Startup))]
namespace MVCTarea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
