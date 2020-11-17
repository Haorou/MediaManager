using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class SaisonRepository : IRepository
    {
        private MediaManagerContext _context;

        public void Dispose()
        {

        }

        public SaisonRepository(MediaManagerContext context)
        {
            _context = context;
        }

        public List<Saison> GetAll()
        {
            var elements = _context.Saisons.ToList();
            return elements;
        }

        public Saison Get(int id)
        {
            return _context.Saisons.Single(x => x.Id == id);
        }

        public void Save(Saison element)
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

        public void Delete(int id)
        {
            var elementDb = _context.Saisons.Single(x => x.Id == id);
            _context.Saisons.Remove(elementDb);
        }

    }
}
