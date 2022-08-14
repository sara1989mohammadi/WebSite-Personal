using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        private readonly DataContext _context;
        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
        public void Delete(int id)
        {
            _context.Set<TEntity>().Remove(FindById(id));
        }
        public virtual TEntity FindById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id == Convert.ToInt32(id));
        }        

        public void Insert(TEntity entity)
        {
            if (entity != null)
            {
                _context.Set<TEntity>().Add(entity);
            }
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
        }
        public void Update(int id)
        {
            _context.Set<TEntity>().Update(FindById(id));
        }
    }
}
