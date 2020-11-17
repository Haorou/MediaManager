using MediaManager.Entity;
using MediaManager.Repository;
using MediaManager.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Bll
{
    public static class EpisodeBll
    {
        public static List<Episode> GetAll()
        {
            try
            {
                List<Episode> result;
                using (var context = new MediaManagerContext())
                using (var repository = new EpisodeRepository(context))
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

        public static Episode Get(int id)
        {
            if (id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try
            {
                Episode result;
                using (var context = new MediaManagerContext())
                using (var repository = new EpisodeRepository(context))
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

        public static void Save(Episode element)
        {
            if (element == null) { throw new MediaManagerException($"Erreur : {nameof(element)} is null", ExceptionReturnType.Error); }
            try
            {
                using (var context = new MediaManagerContext())
                using (var repository = new EpisodeRepository(context))
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
                using (var repository = new EpisodeRepository(context))
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
