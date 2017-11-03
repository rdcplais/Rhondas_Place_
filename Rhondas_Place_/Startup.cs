using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rhondas_Place_.Startup))]
namespace Rhondas_Place_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
