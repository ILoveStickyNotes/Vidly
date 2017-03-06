using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class GenreType
    {
        public byte Id { get; set; }
        public string Genre { get; set; }

        public static readonly byte Unknown = 0;
    }
}