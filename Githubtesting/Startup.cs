using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Githubtesting.Startup))]
namespace Githubtesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
