using Application.Services;
using Domain.Repositories.Persistence;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureAppServices(this IServiceCollection services)
        {
            services.AddSingleton<CsvDbContext>();
            services.AddSingleton<IBillRepository, BillRepository>();
            services.AddSingleton<ILegislatorRepository, LegislatorRepository>();
            services.AddSingleton<IBillService, BillService>();
            services.AddSingleton<ILegislatorService, LegislatorService>();
            return services;
        }
    }
}
