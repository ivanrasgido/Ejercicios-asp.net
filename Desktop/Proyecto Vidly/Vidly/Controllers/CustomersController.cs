using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        
        
        public ActionResult Index()
        {
            
            return View();
        }

        [Route("Customers/Customers/{id}")]
        public ActionResult Details(int id)
        {
            if( id == 1)
            {
                var persona1 = new Customer() { Name = "John Smith" };
                var vista1 = new CustomerViewModel
                {
                    Persona = persona1
                };
                return View(vista1);
            }else if( id == 2)
            {
                var persona2 = new Customer() { Name = "Mary Williams" };
                var vista2 = new CustomerViewModel
                {
                    Persona = persona2
                };
                return View(vista2);
            }
            else
            {
                 return HttpNotFound();
            }

             
        }

        

    }
}