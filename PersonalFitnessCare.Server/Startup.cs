using System.Reflection;
using Owin;
using Microsoft.Owin;
using Microsoft.Owin.Cors;

using PersonalFitnessCare.Server.Common.Configurations;
using PersonalFitnessCare.Server.Common.Constants;

[assembly: OwinStartup(typeof(PersonalFitnessCare.Server.Startup))]

namespace PersonalFitnessCare.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            
           
            ConfigureAuth(app);
        }
    }
}
