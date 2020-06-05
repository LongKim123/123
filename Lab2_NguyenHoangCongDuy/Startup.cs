using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_NguyenHoangCongDuy.Startup))]
namespace Lab2_NguyenHoangCongDuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
