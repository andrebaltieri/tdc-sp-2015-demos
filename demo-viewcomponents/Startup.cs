using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.Framework.DependencyInjection;
using MvcDi.Data;
using MvcDi.Repositories;

namespace MvcDi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Injeção de dependência
            services.AddTransient<IStudentRepository, StudentRepository>();

            services.AddEntityFramework()
                .AddInMemoryStore()
                .AddDbContext<MvcDiDataContext>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseErrorPage(ErrorPageOptions.ShowAll);
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}