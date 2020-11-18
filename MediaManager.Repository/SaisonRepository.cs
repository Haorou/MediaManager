using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class SaisonRepository : RepositoryBase<Saison>, IRepository<Saison>
    {
        public SaisonRepository(MediaManagerContext context) : base(context) { }

        public override Saison Get(int id)
        {
            return _context.Saisons.Single(x => x.Id == id);
        }

        public override void Save(Saison element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Saisons.Single(x => x.Id == element.Id);
                elementDb.Numero = element.Numero;
                elementDb.DateSortie = element.DateSortie;
                elementDb.Episodes = element.Episodes;
                _context.Update(elementDb);
            }
            else
            {
                _context.Saisons.Add(element);
            }
        }

        public override void Delete(int id)
        {
            var elementDb = _context.Saisons.Single(x => x.Id == id);
            _context.Saisons.Remove(elementDb);
        }

    }
}
