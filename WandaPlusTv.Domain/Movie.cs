using System;
using System.Collections.Generic;
using System.Text;

namespace WandaPlusTv.Domain
{
    public class Movie
    {
        public string Name { get; set; }
        public string Episode { get; set; }
        public string Saison { get; set; } = "S00";
        public string Detail { get; set; }
        public int GenreId { get; set; }
        public int CategoryId { get; set; }
        public string VideoCode { get; set; }
        public Genre Genre { get; set; }
        public Category Category { get; set; }
    }
}
