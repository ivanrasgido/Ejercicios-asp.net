using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies / Random
        /* public ActionResult Random()
         {
             var movie = new Movie() { Name = "Shrek!" };

             var customers = new List<Customer>
             {
                 new Customer { Name = "Customer 1"},
                 new Customer { Name = "Customer 2"}
             };

             var viewModel = new RandomMovieViewModel
             {
                 Movie = movie,
                 Customers = customers

             };

             return View(viewModel);
             //return Content("Hola mundo");
             //return HttpNotFound();
             //return new EmptyResult();
             //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
         }*/
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {

      

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }    
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                //Mapper.map(customer,customerInDb);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
                
                
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres 
            };
            return View("MovieForm", viewModel);
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }


        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                 Genres= _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.ToList().SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();
            return View(movie);

        }


        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }*/
        //movies

        /*public ActionResult index(int? pageIndex , string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/

        /* [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
         public ActionResult ByReleaseYear(int year , int month)
         {
             return Content( year + "/" + month);
         }*/
    }
}