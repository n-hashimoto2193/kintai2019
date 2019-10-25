using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kintai2019.Startup))]
namespace Kintai2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
