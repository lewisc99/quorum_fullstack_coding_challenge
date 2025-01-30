using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace YourApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<CsvDbContext>();
            return services;
        }
    }
}
