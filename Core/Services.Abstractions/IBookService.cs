using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAll();
        BookDto GetById(int id);
        void Insert(BookDto entity);
        void Update(int id);
        void Delete(int id);
    }
}
