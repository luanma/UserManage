using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserManage.Web.Startup))]
namespace UserManage.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
