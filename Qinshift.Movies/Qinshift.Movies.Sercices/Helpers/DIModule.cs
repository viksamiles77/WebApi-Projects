using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qinshft.Movies.DataAccess;
using Qinshft.Movies.DataAccess.Implementation;
using Qinshft.Movies.DataAccess.Interfaces;

namespace Qinshift.Movies.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MovieRentDbContext>
                (opts => opts.UseSqlServer (connectionString));

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IMovieRepository, MovieRepository>();
            return services;
        }
    }
}
