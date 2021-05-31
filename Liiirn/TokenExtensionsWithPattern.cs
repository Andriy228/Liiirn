using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liiirn
{
    public class TokenExtensionsWithPattern
    {
        private RequestDelegate _next;
        private string pattern;

        public TokenExtensionsWithPattern(RequestDelegate next, string pattern_)
        {
            _next = next;
            pattern = pattern_;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
             
            if (token != pattern)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Failed with pattern");
            }
            else
            {
                await  _next.Invoke(context);
            }
        }
    }
}
