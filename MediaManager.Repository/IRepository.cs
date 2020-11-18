using System;
using System.Collections.Generic;

namespace MediaManager.Repository
{
    interface IRepository<T> : IDisposable
    {
        List<T> GetAll();
        T Get(int id);
        void Save(T element);
        void Delete(int id);
    }
}
