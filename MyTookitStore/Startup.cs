using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTookitStore.Startup))]
namespace MyTookitStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
