using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenQuangHuy_1811063275.Startup))]
namespace NguyenQuangHuy_1811063275
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
