using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using message.Models;

namespace message
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSingleton<ConsoleErrorHandler>();
            services.AddSingleton<FileErrorHandler>();
            services.AddSingleton<DatabaseErrorHandler>();
            services.AddSingleton<ErrorHandler>(sp =>
            {
                var consoleErrorHandler = sp.GetRequiredService<ConsoleErrorHandler>();
                var fileErrorHandler = sp.GetRequiredService<FileErrorHandler>();
                var databaseErrorHandler = sp.GetRequiredService<DatabaseErrorHandler>();

                consoleErrorHandler.SetNextHandler(fileErrorHandler);
                fileErrorHandler.SetNextHandler(databaseErrorHandler);

                return consoleErrorHandler;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
