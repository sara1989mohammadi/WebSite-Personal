using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryBase<T1> where T1:class
    {
        Task<IEnumerable<T1>> GetAll();
        T1 GetById(int id);
        T1 Insert(T1 item);
        void Update(int id);
        T1 FindById(int id);
        void Delete(int id);
        //Task Save();
    }
}
