using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaManager.Entity
{
    public abstract class Media
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public DateTime? DateSortie { get; set; }
        public string Synopsis { get; set; }
        public List<Acteur> Casting { get; set; }
        public int DureeEnMinute { get; set; }
    }
}
