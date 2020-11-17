using MediaManager.Entity;
using MediaManager.Repository;
using MediaManager.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Bll
{
    public static class SerieBll
    {
        public static List<Serie> GetAll()
        {
            try
            {
                List<Serie> result;
                using (var context = new MediaManagerContext())
                using (var repository = new SerieRepository(context))
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

        public static Serie Get(int id)
        {
            if (id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try
            {
                Serie result;
                using (var context = new MediaManagerContext())
                using (var repository = new SerieRepository(context))
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

        public static void Save(Serie element)
        {
            if (element == null) { throw new MediaManagerException($"Erreur : {nameof(element)} is null", ExceptionReturnType.Error); }
            try
            {
                using (var context = new MediaManagerContext())
                using (var repository = new SerieRepository(context))
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
                using (var repository = new SerieRepository(context))
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
