using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]

        public int id { get; set; }

        [Display(Name ="Logo")]
        public string Logo { get; set; }
        [Display(Name ="Cinema Name")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }

        // Relationships

        public List<Movie> Movies { get; set; }
    }
}
