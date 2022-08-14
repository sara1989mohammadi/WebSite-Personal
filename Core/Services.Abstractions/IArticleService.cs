using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IArticleService
    {
        IEnumerable<ArticleDto> GetAll();
        ArticleDto GetById(int id);
        void Insert(ArticleDto entity);
        void Update(int id);
        void Delete(int id);
    }
}
