using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Datingapi.Interface;
using Datingapi.Services;
using Datingapi.Data;
using Microsoft.EntityFrameworkCore;
namespace Datingapi.Extensions
{
    public class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfigurationSectionHandler config)
        {
            services.AddDbContext<DataContext>(options =>
           {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));
           });
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}