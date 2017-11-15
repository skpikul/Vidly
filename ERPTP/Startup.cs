using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERPTP.Startup))]
namespace ERPTP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
