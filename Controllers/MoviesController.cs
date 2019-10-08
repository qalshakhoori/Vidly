using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [HttpGet]
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name="Ferdinand" } ;
            List<Customer> customers = new List<Customer>
            {
                new Customer { Name="Customer 1" },
                new Customer { Name="Customer 2"}
            };

            RandomViewModel viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}