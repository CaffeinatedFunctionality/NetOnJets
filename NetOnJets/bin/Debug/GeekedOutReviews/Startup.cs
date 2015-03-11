using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeekedOutReviews.Startup))]
namespace GeekedOutReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
