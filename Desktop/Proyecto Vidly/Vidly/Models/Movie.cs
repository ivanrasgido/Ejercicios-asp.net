using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
       
        public DateTime DateAdded { get; set; }
        
        [Display(Name ="Number in Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        
    }
}