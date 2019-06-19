using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public float Rating { get; set; }
        public decimal? Budget { get; set; }
        public int GenreID { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}