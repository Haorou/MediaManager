using MediaManager.Entity;
using MediaManager.Repository;
using MediaManager.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Bll
{
    public static class FilmBll
    {
        public static List<Film> GetAll()
        {
            try
            {
                List<Film> result;
                using(var context = new MediaManagerContext())
                using(var repository = new FilmRepository(context))
                {
                    result = repository.GetAll();
                }
                return result;
            }
            catch(Exception ex)
            {
                throw new MediaManagerException($"Erreur : {ex.Message}", ExceptionReturnType.Error);
            }
        }

        public static Film Get(int id)
        {
            if(id <= 0) { throw new MediaManagerException($"Erreur : {nameof(id)} <= 0", ExceptionReturnType.Error); }
            try 
            {
                Film result;
                using (var context = new MediaManagerContext())
                using (var repository = new FilmRepository(context))
                {
                    result = repository.Get(id);
                }
                return result;
            }
            catch(Exception ex)
            {
                throw new MediaManagerException($"Erreur : {ex.Message}", ExceptionReturnType.Error);
            }
        }

        public static void Save(Film element)
        {
            if(element == null) { throw new MediaManagerException($"Erreur : {nameof(element)} is null", ExceptionReturnType.Error); }
            try 
            {
                using(var context = new MediaManagerContext())
                using(var repository = new FilmRepository(context))
                {
                    repository.Save(element);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
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
                using (var repository = new FilmRepository(context))
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
