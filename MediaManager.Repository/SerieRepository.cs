using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class SerieRepository : IRepository
    {
        private MediaManagerContext _context;

        public void Dispose()
        {

        }

        public SerieRepository(MediaManagerContext context)
        {
            _context = context;
        }

        public List<Serie> GetAll()
        {
            var elements = _context.Series.ToList();
            return elements;
        }

        public Serie Get(int id)
        {
            return _context.Series.Single(x => x.Id == id);
        }

        public void Save(Serie element)
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

        public void Delete(int id)
        {
            var elementDb = _context.Series.Single(x => x.Id == id);
            _context.Series.Remove(elementDb);
        }

    }
}
