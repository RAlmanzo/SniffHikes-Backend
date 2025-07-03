using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SniffHikes_Backend.Infrastructure.Data;
using SniffHikes_Backend.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config) 
        {
            services.Configure<FirebaseSettings>(config.GetSection("Firebase"));
            services.AddSingleton<FirebaseDbContext>();

            return services;
        }
    }
}
