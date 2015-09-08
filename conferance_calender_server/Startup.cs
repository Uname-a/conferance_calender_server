using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(conferance_calender_server.Startup))]
namespace conferance_calender_server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
