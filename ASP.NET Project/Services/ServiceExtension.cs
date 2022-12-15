using ASP.NET_Project.Repositories.Locations;
using ASP.NET_Project.Services.Locations;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace ASP.NET_Project.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILocationRepo, LocationRepo>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ILocationService, LocationService>();
            return services;
        }
    }
}
