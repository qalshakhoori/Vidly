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
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Id=1, Name="Ferdinand" },
                new Movie { Id=2, Name="Shrek"}
            };
            return View(movies);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id != 1 && id != 2)
            {
                return HttpNotFound();
            }
            List<Movie> movies = new List<Movie>
            {
                new Movie { Id=1, Name="Ferdinand" },
                new Movie { Id=2, Name="Shrek"}
            };

            return View(movies.FirstOrDefault(c => c.Id == id));
        }
    }
}