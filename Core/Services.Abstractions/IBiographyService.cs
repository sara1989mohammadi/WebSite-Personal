using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IBiographyService
    {
        IEnumerable<BiographyDto> GetAll();
        BiographyDto GetById(int id);
        void Insert(BiographyDto entity);
        void Update(int id);
        void Delete(int id);
    }
}
