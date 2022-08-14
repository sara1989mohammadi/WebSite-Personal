using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IActivityService
    {
        Task<IEnumerable<ActivityDto>> GetAll();
        ActivityDto GetById(int id);
        ActivityDto Insert(ActivityDto item);
        void Update(int id);
        ActivityDto FindById(int id);
        void Delete(int id);
    }
}
