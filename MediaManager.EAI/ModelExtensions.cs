using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.EAI
{
    public static class ModelExtensions
    {
        public static Entity.Film ToFilmEntity(this movies element)
        {
            return new Film
            {
                Nom = element.movie.title,
                DateSortie = element.movie.release_date,
                DureeEnMinute = element.movie.length,
                Synopsis = element.movie.synopsis,
                Casting = new List<Acteur>()
            };
        }
    }
}
