using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte GenreTypeId { get; set; }
    }
}