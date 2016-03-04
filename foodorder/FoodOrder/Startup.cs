using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodOrder.Startup))]
namespace FoodOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
