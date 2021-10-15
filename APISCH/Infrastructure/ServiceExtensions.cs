using System.Security.Cryptography;
using APISCH.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace APISCH.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigCores(this IServiceCollection service)
        {
            service.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder =>
                    {
                        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                    });
            });

        }

        public static void ConfigIISIntegration(this IServiceCollection service)
        {
            service.Configure<IISOptions>(opts => { });
        }

        public static void ConfigRepository(this IServiceCollection service)
        {
            service.AddTransient<UnitOfWork<ApplicationContext>>();
        }


        public static void ConfigLoggerManager(this IServiceCollection service)
        {
            service.AddScoped<ILoggerManager, LoggerManager>();
        }

        public static IMvcBuilder AddCustomCsvFormatter(this IMvcBuilder builder)
        {
            return builder.AddMvcOptions(config => config.OutputFormatters.Add(new
                CVSOutputForamter()));
        }
    }
}