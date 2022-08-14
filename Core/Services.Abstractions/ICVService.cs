using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface ICVService
    {
        IEnumerable<CVDto> GetAll();
        CVDto GetById(int id);
        void Insert(CVDto entity);
        void Update(int id);
        void Delete(int id);
    }
}
