using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnStartup
{
    public class MyStartup
    {
        private IConfiguration _myConfig { get; }
        public MyStartup(IConfiguration configuration)
        {
             _myConfig = configuration;
        }
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllersWithViews();
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
                
            }
            app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                     string Get()
                    {
                        return _myConfig.GetSection("Logging").GetSection("LogLevel").GetValue<string>("Microsoft.Hosting.Lifetime"); // here  
                    }

                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync(_myConfig["ThisTest"] + "\n");//Logging.LogLevel."Microsoft.Hosting.Lifetime"
                        await context.Response.WriteAsync("Microsoft.Hosting.Lifetime:  "+ Get());
                       
                    });

                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                });
            }
        
    }
}
