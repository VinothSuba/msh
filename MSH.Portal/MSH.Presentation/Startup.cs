using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSH.Presentation.Startup))]
namespace MSH.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
