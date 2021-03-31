using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlataformaDeVuelos.Startup))]
namespace PlataformaDeVuelos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
