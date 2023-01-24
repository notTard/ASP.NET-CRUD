using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Notes.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection 
            services,IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<NotesDBContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<NotesDBContext>(provider =>
            provider.GetService<NotesDBContext>());
            return services;
        }
    }
}
