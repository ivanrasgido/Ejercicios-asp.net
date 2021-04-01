using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PlataformaDeVuelos.Models;

namespace PlataformaDeVuelos.Controllers
{
    public class VuelosController : Controller
    {
        public ApplicationDbContext _context;

        public VuelosController ()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        // GET: Vuelos
        public ActionResult Index()
        {
            var vuelo = _context.Vuelos.ToList();
            return View(vuelo);
        }

        public ActionResult Alta()
        {

            return View();
        }
       

        

        public ActionResult Modificar(int id)
        {
            var vuelo = _context.Vuelos.SingleOrDefault(c => c.Id == id);
            if (vuelo == null)
            {
                return HttpNotFound();
            }
           

            return View("Modificacion", vuelo);
           
        }

        public ActionResult Guardar(VueloModels vuelo)
        {
            if (vuelo.Id == 0)
                _context.Vuelos.Add(vuelo);
            else
            {
                var vueloInDb = _context.Vuelos.Single(c => c.Id == vuelo.Id);

                vueloInDb.HorarioDeLlegada = vuelo.HorarioDeLlegada;
                vueloInDb.LineaAerea = vuelo.LineaAerea;
                vueloInDb.NumeroDeVuelo = vuelo.NumeroDeVuelo;
                vueloInDb.Demorado = vuelo.Demorado;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Vuelos");
        }

        public ActionResult Borrar(int id)
        {
            var customerInDb = _context.Vuelos.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Vuelos.Remove(customerInDb);
            _context.SaveChanges();

            return RedirectToAction("Index","Vuelos");
        }
    }
}