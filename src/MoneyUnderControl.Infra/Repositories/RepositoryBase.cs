using Microsoft.EntityFrameworkCore;
using MoneyUnderControl.Domain.Interfaces;
using MoneyUnderControl.Infra.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoneyUnderControl.Infra.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected readonly MoneyUnderControlContext Context;

        public RepositoryBase(MoneyUnderControlContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public async Task<T> GetById(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public void Add(T model)
        {
            Context.Set<T>().Add(model);
            Context.SaveChanges();
        }

        public void Update(T model)
        {
            Context.Set<T>().Update(model);
            Context.SaveChanges();
        }

        public void Remove(T model)
        {
            Context.Set<T>().Remove(model);
            Context.SaveChanges();
        }
    }
}