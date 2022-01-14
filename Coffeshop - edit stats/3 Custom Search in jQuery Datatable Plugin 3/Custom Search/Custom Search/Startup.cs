using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Custom_Search.Startup))]
namespace Custom_Search
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
