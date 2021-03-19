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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                var pelicula1 = new Movie() { Name = "Shrek" };
                var vista1 = new MovieViewModel
                {
                     Pelicula = pelicula1
                };
                return View(vista1);
            }
            else if (id == 2)
            {
                var pelicula2 = new Movie() { Name = "Wall-e" };
                var vista2 = new MovieViewModel
                {
                    Pelicula = pelicula2
                };
                return View(vista2);
            }
            else
            {
                return HttpNotFound();
            }
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