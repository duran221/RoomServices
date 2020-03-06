using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomServices.Startup))]
namespace RoomServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
