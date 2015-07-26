using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Abt.Data;

namespace aspnetcast
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddEntityFramework()
                .AddInMemoryStore()
                .AddDbContext<AbtDataContext>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "api",
                        template: "{controller}/{id?}");
                });
        }
    }
}