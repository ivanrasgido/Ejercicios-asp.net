using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlataformaDeVuelos.Models
{
    public class VueloModels
    {
        public int Id { get; set; }
        [Required]
        [StringLength(8)]
        [Display(Name = "Numero de Vuelo")]
        public string NumeroDeVuelo { get; set; }
        [Required]
        [Display( Name ="Horario de Llegada")]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public DateTime HorarioDeLlegada { get; set; }
        
       
        [Required]
        [Display( Name = "Linea Aerea")]
        public string LineaAerea { get; set; }
        
        
        public bool Demorado { get; set; }
    }
}