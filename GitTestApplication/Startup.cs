using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTestApplication.Startup))]
namespace GitTestApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
