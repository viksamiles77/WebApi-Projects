using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;

namespace Qinshft.Movies.DataAccess.Implementation
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieRentDbContext ctx) : base(ctx)
        {
        }
    }
}
