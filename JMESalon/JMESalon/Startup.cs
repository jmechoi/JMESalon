using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMESalon.Startup))]
namespace JMESalon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
