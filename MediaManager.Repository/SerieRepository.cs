using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class SerieRepository : RepositoryBase<Serie>, IRepository<Serie>
    {
        public SerieRepository(MediaManagerContext context) : base (context) { }

        public override Serie Get(int id)
        {
            return _context.Series.Single(x => x.Id == id);
        }

        public override void Save(Serie element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Series.Single(x => x.Id == element.Id);
                elementDb.Nom = element.Nom;
                elementDb.DateSortie = element.DateSortie;
                elementDb.DureeEnMinute = element.DureeEnMinute;
                elementDb.Synopsis = element.Synopsis;
                _context.Update(elementDb);
            }
            else
            {
                _context.Series.Add(element);
            }
        }

        public override void Delete(int id)
        {
            var elementDb = _context.Series.Single(x => x.Id == id);
            _context.Series.Remove(elementDb);
        }

    }
}
