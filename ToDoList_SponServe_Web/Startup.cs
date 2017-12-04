using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoList_SponServe_Web.Startup))]
namespace ToDoList_SponServe_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
