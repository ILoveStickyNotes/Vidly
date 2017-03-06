using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        public GenreType GenreType { get; set; }

        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }
    }

   

}