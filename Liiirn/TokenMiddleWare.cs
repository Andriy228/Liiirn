using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liiirn
{
    public class TokenMiddleWare
    {
        private RequestDelegate _next;

        public TokenMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];

            if(token != "fishing")
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Failed!!!");
            }
            else
            {
               await _next.Invoke(context);
            }
        }
    }
}
