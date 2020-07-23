using System.Collections.Generic;
using Infrastructure.Database.DTO;

namespace Infrastructure.Database.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        T Create(T entity);
        T Update(int id, T entity);
        T Remove(int id);
    }
}