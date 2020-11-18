using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class EpisodeRepository : RepositoryBase<Episode>, IRepository<Episode>
    {
        public EpisodeRepository(MediaManagerContext context) : base(context) { }

        public override Episode Get(int id)
        {
            return _context.Episodes.Single(x => x.Id == id);
        }

        public override void Save(Episode element)
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

        public override void Delete(int id)
        {
            var elementDb = _context.Episodes.Single(x => x.Id == id);
            _context.Episodes.Remove(elementDb);
        }

    }
}
