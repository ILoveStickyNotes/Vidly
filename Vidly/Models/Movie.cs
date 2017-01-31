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
        public string ReleaseDate { get; set; }
        public string DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public GenreType GenreType { get; set; }
        public byte GenreTypeId { get; set; }
    }

   

}