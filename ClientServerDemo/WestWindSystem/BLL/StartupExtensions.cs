using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;

namespace WestWindSystem.BLL
{
    public static class StartupExtensions
    {
        public static void AddBackendDependencies(
        this IServiceCollection services,
        Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<WestWindContext>(options);


            services.AddTransient<BuildVersionService>(serviceProvider =>
            {
                var context = serviceProvider.GetRequiredService<WestWindContext>();
                return new BuildVersionService(context);
            });

            services.AddTransient<CategoryServices>(serviceProvider => {
                var context = serviceProvider.GetRequiredService<WestWindContext>();
                return new CategoryServices(context);
            });
        }
    }
}
