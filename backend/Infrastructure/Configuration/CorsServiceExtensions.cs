using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class CorsServiceExtensions
    {
        private const string MyAllowSpecificOrigins = "ReactAppPolicy";

        public static IServiceCollection ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:5174")
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });

            return services;
        }
    }
}
