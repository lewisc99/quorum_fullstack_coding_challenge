using Asp.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class VersioningServiceEntensions
    {
        public static IServiceCollection ConfigureVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(
                         cfg =>
                         {
                             cfg.ReportApiVersions = true;
                             cfg.ApiVersionReader = new HeaderApiVersionReader("api-version");
                             cfg.AssumeDefaultVersionWhenUnspecified = true;
                             cfg.DefaultApiVersion = new ApiVersion(1, 0);
                         })
                .AddMvc()
                .AddApiExplorer(options =>
                {
                    options.GroupNameFormat = "'v'V";
                    options.SubstituteApiVersionInUrl = true;
                });

            return services;
        }
    }
}
