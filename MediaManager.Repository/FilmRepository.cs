using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class FilmRepository : RepositoryBase<Film>, IRepository<Film>
    {
        public FilmRepository(MediaManagerContext context) : base(context) { }

        public override Film Get(int id)
        {
            return _context.Films.Single(x => x.Id == id);
        }

        public override void Save(Film element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Films.Single(x => x.Id == element.Id);
                elementDb.Nom = element.Nom;
                elementDb.DateSortie = element.DateSortie;
                elementDb.DureeEnMinute = element.DureeEnMinute;
                elementDb.Synopsis = element.Synopsis;
                _context.Update(elementDb);
            }
            else
            {
                _context.Films.Add(element);
            }
        }
        
        public override void Delete(int id)
        {
            var elementDb = _context.Films.Single(x => x.Id == id);
            _context.Films.Remove(elementDb);
        }

    }
}
