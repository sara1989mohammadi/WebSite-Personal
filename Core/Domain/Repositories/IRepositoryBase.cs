using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity FindById(int id);
        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Update(int id);
        void Delete(TEntity entity);
        void Delete(int id);
        void Delete(IEnumerable<TEntity> entities);
    }
}
