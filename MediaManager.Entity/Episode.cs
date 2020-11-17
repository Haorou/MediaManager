using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Entity
{
    public class Episode : Media 
    {
        public int SaisonId { get; set; }
        public Saison Saison { get; set; }
    }
}
