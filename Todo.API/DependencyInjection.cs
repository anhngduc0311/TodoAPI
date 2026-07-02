using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todo.Infrastructure;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<TodoAppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddAutoMapper(typeof(InfraAssemblyMarker).Assembly);

            return services;
        }
    }
}
