using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}