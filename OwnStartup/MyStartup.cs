using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnStartup
{
    public class MyStartup
    {
        private IConfiguration _myConfig { get; }
        public MyStartup(IConfiguration config)
        {
            config = _myConfig;
        }
            public void ConfigureServices(IServiceCollection services)
            {

            }

            public void Configure(IApplicationBuilder app)
            {
                 app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync(_myConfig["ThisTest"]);
                    });
                   
                });
            }
        
    }
}
