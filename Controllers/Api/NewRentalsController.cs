using System;
using System.Linq;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (Movie movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;
                _context.Rentals.Add(new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = new DateTime()
                });
            }

            _context.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}