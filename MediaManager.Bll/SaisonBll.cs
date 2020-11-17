using MediaManager.Entity;
using MediaManager.Repository;
using MediaManager.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Bll
{
    public static class SaisonBll
    {
        public static List<Saison> GetAll()
        {
            try
            {
                List<Saison> result;
                using (var context = new MediaManagerContext())
                using (var repository = new SaisonRepository(context))
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

        public static Saison Get(int id)
        {
            if (id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try
            {
                Saison result;
                using (var context = new MediaManagerContext())
                using (var repository = new SaisonRepository(context))
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

        public static void Save(Saison element)
        {
            if (element == null) { throw new MediaManagerException($"Erreur : {nameof(element)} is null", ExceptionReturnType.Error); }
            try
            {
                using (var context = new MediaManagerContext())
                using (var repository = new SaisonRepository(context))
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
                using (var repository = new SaisonRepository(context))
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
