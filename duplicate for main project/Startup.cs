using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duplicate_for_main_project.Startup))]
namespace duplicate_for_main_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
