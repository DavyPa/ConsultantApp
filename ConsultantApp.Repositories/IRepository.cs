using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultantApp.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Update(T entity);
        void Delete(T entity);
        T Create(T entity);
    }
}
