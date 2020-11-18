using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Repository
{
    public class ActeurRepository : RepositoryBase<Acteur>, IRepository<Acteur>
    {

        public ActeurRepository(MediaManagerContext context) : base(context) {}

        public override Acteur Get(int id)
        {
            return _context.Acteurs.Single(x => x.Id == id);
        }

        public override void Save(Acteur element)
        {
            if (element.Id > 0)
            {
                var elementDb = _context.Acteurs.Single(x => x.Id == element.Id);
                elementDb.Nom = element.Nom;
                elementDb.Prenom = element.Prenom;
                _context.Update(elementDb);
            }
            else
            {
                _context.Acteurs.Add(element);
            }
        }

        public override void Delete(int id)
        {
            var elementDb = _context.Acteurs.Single(x => x.Id == id);
            _context.Acteurs.Remove(elementDb);
        }

    }
}
