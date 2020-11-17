using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class ActeurRepository : IRepository
    {
        private MediaManagerContext _context;

        public void Dispose()
        {

        }

        public ActeurRepository(MediaManagerContext context)
        {
            _context = context;
        }

        public List<Acteur> GetAll()
        {
            var elements = _context.Acteurs.ToList();
            return elements;
        }

        public Acteur Get(int id)
        {
            return _context.Acteurs.Single(x => x.Id == id);
        }

        public void Save(Acteur element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Acteurs.Single(x => x.Id == element.Id);
                elementDb.Nom = element.Nom;
                elementDb.Prenom = element.Prenom;
                elementDb.Display = element.Display;
                _context.Update(elementDb);
            }
            else
            {
                _context.Acteurs.Add(element);
            }
        }

        public void Delete(int id)
        {
            var elementDb = _context.Acteurs.Single(x => x.Id == id);
            _context.Acteurs.Remove(elementDb);
        }

    }
}
