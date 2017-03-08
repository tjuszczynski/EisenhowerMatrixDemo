using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacierzEinsenhoweraDemo.Startup))]
namespace MacierzEinsenhoweraDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
