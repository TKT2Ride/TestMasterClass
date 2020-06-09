using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMasterClass.Startup))]
namespace TestMasterClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
