using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class EpisodeRepository : IRepository
    {
        private MediaManagerContext _context;

        public void Dispose()
        {

        }

        public EpisodeRepository(MediaManagerContext context)
        {
            _context = context;
        }

        public List<Episode> GetAll()
        {
            var elements = _context.Episodes.ToList();
            return elements;
        }

        public Episode Get(int id)
        {
            return _context.Episodes.Single(x => x.Id == id);
        }

        public void Save(Episode element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Episodes.Single(x => x.Id == element.Id);
                elementDb.Nom = element.Nom;
                elementDb.DateSortie = element.DateSortie;
                elementDb.DureeEnMinute = element.DureeEnMinute;
                elementDb.Synopsis = element.Synopsis;
                _context.Update(elementDb);
            }
            else
            {
                _context.Episodes.Add(element);
            }
        }

        public void Delete(int id)
        {
            var elementDb = _context.Episodes.Single(x => x.Id == id);
            _context.Episodes.Remove(elementDb);
        }

    }
}
