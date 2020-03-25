using DocConverter.Infrastructure.EntityFramework.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppReact.Configuration
{
    /// <summary>
    /// IOC configuration
    /// </summary>
    public static class ServiceConfigurations
    {
        /// <summary>
        /// ConfigurationDb
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DocConverterContext>(opts => opts.UseNpgsql(configuration.GetConnectionString("SqlConnection")));
        }

        /// <summary>
        /// Authentication Configuration
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });
        }
    }
}
