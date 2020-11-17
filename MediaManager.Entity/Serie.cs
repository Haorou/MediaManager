using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Entity
{
    public class Serie : Media
    {
        public List<Saison> Saisons { get; set; }
    }
}
