using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService: IBookService
    {
        private readonly IRepositoryManager _repositoryManager;
        public BookService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void Delete(int id)
        {
            _repositoryManager.repositoryBook.Delete(id);
        }

        public IEnumerable<BookDto> GetAll()
        {
            var book = _repositoryManager.repositoryBook.GetAll();
            var bookDto = book.Adapt<IEnumerable<BookDto>>();
            return bookDto;
        }

        public BookDto GetById(int id)
        {
            if (id == 0)
                return null;

            var book = _repositoryManager.repositoryBook.GetById(id);
            return book.Adapt<BookDto>();
        }

        public void Insert(BookDto entity)
        {
            var book = entity.Adapt<Book>();
            _repositoryManager.repositoryBook.Insert(book);
            _repositoryManager.UnitOfWork.SaveChanges();

        }

        public void Update(int id)
        {
            _repositoryManager.repositoryBook.Update(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }
    }
}

