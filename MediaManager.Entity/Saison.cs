using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MediaManager.Entity
{
    public class Saison
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime? DateSortie { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
