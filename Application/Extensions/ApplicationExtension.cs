using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplicationConfiguration (this IServiceCollection services) {
         
            
            // services.AddMediatR(typeof(ApplicationExtension).Assembly);
          


            return services;
        }
    }
}
