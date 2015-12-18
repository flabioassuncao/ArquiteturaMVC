using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA.ArquiteturaMVC.UI.Startup))]
namespace FA.ArquiteturaMVC.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
