using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            var movies = _context.Movies.ToList().Select(Mapper.Map<Movie, MoviesDto>);

            return Ok(movies);
        }

        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movie>(moviesDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            moviesDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), moviesDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map(moviesDto, movieInDb);

            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movieInDb.Id), moviesDto);
        }
    }
}