using MediaManager.Entity;
using MediaManager.Repository;
using MediaManager.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Bll
{
    public static class ActeurBll
    {
        public static List<Acteur> GetAll()
        {
            try
            {
                List<Acteur> result;
                using (var context = new MediaManagerContext())
                using (var repository = new ActeurRepository(context))
                {
                    result = repository.GetAll();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new MediaManagerException($"Erreur : {ex.Message}", ExceptionReturnType.Error);
            }
        }

        public static Acteur Get(int id)
        {
            if (id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try
            {
                Acteur result;
                using (var context = new MediaManagerContext())
                using (var repository = new ActeurRepository(context))
                {
                    result = repository.Get(id);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new MediaManagerException($"Erreur : {ex.Message}", ExceptionReturnType.Error);
            }
        }

        public static void Save(Acteur element)
        {
            if (element == null) { throw new MediaManagerException($"Erreur : {nameof(element)} is null", ExceptionReturnType.Error); }
            try
            {
                using (var context = new MediaManagerContext())
                using (var repository = new ActeurRepository(context))
                {
                    repository.Save(element);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new MediaManagerException($"Erreur :{ex.Message}", ExceptionReturnType.Error);
            }
        }

        public static void Delete(int id)
        {
            if (id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try
            {
                using (var context = new MediaManagerContext())
                using (var repository = new ActeurRepository(context))
                {
                    repository.Delete(id);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new MediaManagerException($"Erreur : {ex.Message}", ExceptionReturnType.Error);
            }
        }
    }
}
