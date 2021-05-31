using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Liiirn
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
       /* public void Configure(IApplicationBuilder app)
        {
            app.Map("/index", Index);
            app.Map("/about", About);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page Not Found");
            });
        }

        private static void Index(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Index");
            });
        }

        private static void About(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("About");
            });
        }
       */
        /*public void Configure(IApplicationBuilder app)
        {
            app.MapWhen(context => 
                {
                  return  context.Request.Query.ContainsKey("id") &&
                    context.Request.Query["id"] == "5";
                }
            ,Handle);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Don't have id");
            });
        }
        private static void Handle(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Query is: 5");
            });
        }
        */
        /*public void Configure(IApplicationBuilder app)
        {
            app.UseToken("1234");

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Token is Valid!");
            });
        }
        */
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseMiddleware<RoutingMiddleWare>();
        }
    }
}
