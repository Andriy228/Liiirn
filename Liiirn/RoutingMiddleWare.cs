using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liiirn
{
    public class RoutingMiddleWare
    {
        private RequestDelegate next;

        public RoutingMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value.ToLower();

            if(path == "/index")
            {
                await context.Response.WriteAsync("Home Page!!!");
            }
            else if(path == "/about")
            {
                await context.Response.WriteAsync("About Page!!!");
            }
            else
            {
                context.Response.StatusCode = 403;
                await next.Invoke(context);
            }
        }
    }
}
