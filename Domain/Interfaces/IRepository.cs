using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(long id);
        void Add(T objectToAdd);
        void Update(T objectToUpdate);
    }
}
