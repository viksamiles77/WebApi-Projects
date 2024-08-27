using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services.Implementation
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);
        List<MovieDto> FilterMoviesByGenre(string genre);
        List<MovieDto> FilterMoviesByYear(int year);
        int AddNewMovie(MovieCreateDto movie);
        MovieDto UpdateMovie(int id, MovieUpdateDto updatedMovie);
        int DeleteMovieById(int id);
        void DeleteMovieByIdFromBody(int id);
    }
}
