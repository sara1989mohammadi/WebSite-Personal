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
        IEnumerable<ActivityDto> GetAll();
        ActivityDto GetById(int id);       
        void Insert(ActivityDto entity);        
        void Update(int id);              
        void Delete(int id);
        
    }
}
