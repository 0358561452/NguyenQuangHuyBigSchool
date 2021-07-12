using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811063275_NguyenQuangHuy__Lab456.Startup))]
namespace _1811063275_NguyenQuangHuy__Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
