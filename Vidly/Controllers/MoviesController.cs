using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new { page = 1, sortBy = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index()
        {
            var movieList = _context.Movies.Include(m => m.GenreType).ToList();

            return View(movieList);



//            if (!pageIndex.HasValue)
//                pageIndex = 1;
//            if (string.IsNullOrWhiteSpace(sortBy))
//                sortBy = "Name";
//
//            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex,sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")] // Constraints: min,max,minlength,maxlength,int,float,guid
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}