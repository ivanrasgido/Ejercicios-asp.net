using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlataformaDeVuelos.Models;

namespace PlataformaDeVuelos.Controllers.Api
{
    public class VuelosController : ApiController
    {
        public ApplicationDbContext _context;

        public VuelosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpDelete]
        public void DELETE(int id)
        {
            var vueloInDb = _context.Vuelos.SingleOrDefault(c => c.Id == id);

            if (vueloInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Vuelos.Remove(vueloInDb);
            _context.SaveChanges();
        }
    }
}
