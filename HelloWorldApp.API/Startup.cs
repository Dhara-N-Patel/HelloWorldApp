using Microsoft.Owin;
using Owin;
using HelloWorldApp.API.AppConfiguration;

[assembly: OwinStartup(typeof(HelloWorldApp.API.Startup))]

namespace HelloWorldApp.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}