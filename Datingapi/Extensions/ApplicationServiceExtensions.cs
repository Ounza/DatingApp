using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Datingapi.Interface;
using Datingapi.Services;
using Datingapi.Data;
using Microsoft.EntityFrameworkCore;
namespace Datingapi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
           {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));
           });

            return services;
        }
    }
}