using System;
using System.Collections.Generic;

namespace sfm.Domain.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        void Add(T Object);
        void Update(T Object);
        void Delete(T Object);
        T GetEntityById(Guid Id);
        List<T> List();
    }
}
