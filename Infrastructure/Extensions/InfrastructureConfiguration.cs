using Domain.Repositories;
using Infrastructure.Students.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class InfrastructureConfiguration
    {

        public  static IServiceCollection AddInfrastructureConfiguration(this IServiceCollection services) {
         
             
            //A single singleton service is reused during the lifetime of the app 
            services.AddSingleton<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
