using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;
using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services.Helpers
{
    public static class MovieMapper
    {
        public static MovieDto ToMovieDto(Movie movie)
        {
            if (movie == null)
            {
                return null;
            }

            return new MovieDto
            {
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                Genre = movie.Genre.ToString(),
            };
        }

        public static Movie ToMovie(MovieCreateDto movieCreateDto)
        {
            return new Movie
            {
                Title = movieCreateDto.Title,
                Description = movieCreateDto.Description,
                Year = movieCreateDto.Year,
                Genre = (GenreEnum)movieCreateDto.Genre,
            };
        }
        public static Movie ToMovie(MovieUpdateDto movieUpdateDto)
        {
            return new Movie
            {
                Id = movieUpdateDto.Id,
                Title = movieUpdateDto.Title,
                Description = movieUpdateDto.Description,
                Year = movieUpdateDto.Year,
                Genre = movieUpdateDto.Genre,
            };
        }

        public static List<MovieDto> ToMovieDtoList(List<Movie> movies)
        {
            return movies.Select(x => ToMovieDto(x)).ToList();
        }
    }
}
