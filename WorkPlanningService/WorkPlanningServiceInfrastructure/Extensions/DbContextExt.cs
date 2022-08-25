using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorkPlanningService.Infrastructure.Context;

namespace WorkPlanningService.Infrastructure.Extensions
{
    public static class DbContextExt
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"],
            getAssembly => getAssembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }
    }
}
