using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs;
using Qinshift.Movies.Services.Helpers;

namespace Qinshift.Movies.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepo;
        public MovieService(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public List<MovieDto> GetAllMovies()
        {
            var movies = _movieRepo.GetAll();
            var movieListDto = new List<MovieDto>();
            foreach (var movie in movies)
            {
                var movieDto = MovieMapper.ToMovieDto(movie);
                movieListDto.Add(movieDto);
            }
            return movieListDto;
        }

        public int AddNewMovie(MovieCreateDto movie)
        {
            if (movie == null)
            {
                return 0;
            }

            Movie movieModel = MovieMapper.ToMovie(movie);

            int newMovieId = _movieRepo.Add(movieModel);

            return newMovieId;
        }

        public MovieDto GetMovieById(int id)
        {
            var movie = _movieRepo.GetById(id);
            return MovieMapper.ToMovieDto(movie);
        }

        public List<MovieDto> FilterMoviesByGenre(string genre)
        {
            var movies = _movieRepo.GetAll();
            var movieList = new List<MovieDto>();
            if (!string.IsNullOrEmpty(genre))
            {
                movies = movies.Where(x => x.Genre.ToString().ToLower() == genre.ToLower());
            }
            foreach (var movie in movies)
            {
                var movieDto = MovieMapper.ToMovieDto(movie);
                movieList.Add(movieDto);
            }
            return movieList;
        }
        public List<MovieDto> FilterMoviesByYear(int year)
        {
            var movies = _movieRepo.GetAll();
            var movieList = new List<MovieDto>();

            if (year > 0)
            {
                movies = movies.Where(x => x.Year == year).ToList();
                foreach (var movie in movies)
                {
                    var movieDto = MovieMapper.ToMovieDto(movie);
                    movieList.Add(movieDto);
                }
            }
            return movieList;
        }

        public MovieDto UpdateMovie(int id, MovieUpdateDto updatedMovie)
        {
            var existingMovie = _movieRepo.GetById(id);
            if (existingMovie != null)
            {
                existingMovie.Title = updatedMovie.Title;
                existingMovie.Description = updatedMovie.Description;
                existingMovie.Year = updatedMovie.Year;
                existingMovie.Genre = updatedMovie.Genre;

                _movieRepo.Update(existingMovie);

                return MovieMapper.ToMovieDto(existingMovie);
            }
            return null;
        }

        public int DeleteMovieById(int id)
        {
            var existingMovie = _movieRepo.GetById(id);
            if (existingMovie != null)
            {
                _movieRepo.Remove(existingMovie.Id);
                return 1;
            }
            return 0;
        }

        public void DeleteMovieByIdFromBody(int id)
        {
            DeleteMovieById(id);
        }
    }
}
