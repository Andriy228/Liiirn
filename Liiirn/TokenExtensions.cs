using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liiirn
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder app,string pattern)
        {
            return app.UseMiddleware<TokenExtensionsWithPattern>(pattern);
        }
    }
}
