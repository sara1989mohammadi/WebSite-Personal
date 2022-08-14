using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IShortArticleService
    {
        IEnumerable<ShortArticleDto> GetAll();
        ShortArticleDto GetById(int id);
        void Insert(ShortArticleDto entity);
        void Update(int id);
        void Delete(int id);
    }
}
