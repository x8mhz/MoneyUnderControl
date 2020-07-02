using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoneyUnderControl.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();

        void Add(T model);
        void Update(T model);
        void Remove(T model);

    }
}