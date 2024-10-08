﻿using Microsoft.AspNetCore.Mvc;
using Qinshift.Movies.DTOs.Movie;
using Qinshift.Movies.Services.Implementation;
using Serilog;
using System.Diagnostics;

namespace Qinshift.Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("all")]
        public IActionResult GetAllMovies()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                //Log.Debug("Entered get all movies.");
                Log.Debug("Fetch all movies started.");
                var movies = _movieService.GetAllMovies();

                stopwatch.Stop();
                Log.Debug($"Fetch all movies finished in:{stopwatch.ElapsedMilliseconds}.");

                return Ok(movies);
            }
            catch (Exception ex)
            {
                Log.Error("Error occured while fetching all movies.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            finally
            {
                //Log.Debug("Finished get all movies");
            }
        }


        [HttpGet("{id:int}")]
        public IActionResult GetMovieById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Id must have a positive value!");
                }

                var movie = _movieService.GetMovieById(id);
                if (movie == null)
                {
                    return NotFound($"Movie with id {id} not found.");
                }

                return Ok(movie);
            }
            catch (Exception ex)
            {
                Log.Error($"Error occured while fetching movie as a query string with Id: {id}.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("filter/genre")]
        public IActionResult GetMovieByGenre([FromQuery] string genre)
        {
            try
            {
                if (string.IsNullOrEmpty(genre))
                {
                    return BadRequest("You have to input a movie genre!");
                }

                var movies = _movieService.FilterMoviesByGenre(genre);

                return Ok(movies);

            }
            catch (Exception ex)
            {
                Log.Error($"Error occured while fetching movie as a query string genre: {genre}.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("filter/year")]
        public IActionResult GetMovieByYear([FromQuery] int year)
        {
            try
            {
                var movieDtos = _movieService.FilterMoviesByYear(year);
                return Ok(movieDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPut("update")]
        public IActionResult UpdateMovie([FromBody] MovieUpdateDto movieUpdateDto)
        {
            if (movieUpdateDto == null || movieUpdateDto.Id == 0)
            {
                return BadRequest("Invalid movie data.");
            }

            var updatedMovieDto = _movieService.UpdateMovie(movieUpdateDto.Id, movieUpdateDto);

            if (updatedMovieDto == null)
            {
                return NotFound("Movie not found.");
            }

            return Ok(updatedMovieDto);
        }

        [HttpPost("add")]
        public IActionResult AddNewMovie([FromBody] MovieCreateDto newMovie)
        {
            try
            {
                if (newMovie == null)
                    return BadRequest("Movie data cannot be null.");

                int newMovieId = _movieService.AddNewMovie(newMovie);

                if (newMovieId == 0)
                    return StatusCode(StatusCodes.Status400BadRequest, "Movie data is invalid.");

                return CreatedAtAction(nameof(GetMovieById), new { id = newMovieId }, newMovie);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovieById(int id)
        {
            _movieService.DeleteMovieById(id);
            return Ok();
        }

        [HttpDelete("byBody")]
        public IActionResult DeleteMovieByIdFromBody([FromBody] int id)
        {
            _movieService.DeleteMovieByIdFromBody(id);
            return Ok();
        }
    }
}