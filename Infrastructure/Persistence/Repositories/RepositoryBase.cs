using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryBase<T1> : IRepositoryBase<T1> where T1 : class
    {
        private readonly DataContext _context;
        public RepositoryBase(DataContext context)
        {
            _context = context;
        }
        public virtual void Delete(int id)
        {
            _context.Set<T1>().Remove(FindById(id));          
        }

        public T1 FindById(int id)
        {
            return _context.Set<T1>().Find(id);
        }

        public async Task<IEnumerable<T1>> GetAll()
        {
            return await _context.Set<T1>().ToListAsync();
        }

        public T1 GetById(int id)
        {
            throw new NotImplementedException();
            //  return _context.Set<T1>().FindById(id);           
        }

        public virtual T1 Insert(T1 item)
        {
            return _context.Set<T1>().Add(item).Entity;
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
