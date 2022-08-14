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
    public class ShortArticleService: IShortArticleService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ShortArticleService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void Delete(int id)
        {
            _repositoryManager.repositoryShortArticle.Delete(id);
        }

        public IEnumerable<ShortArticleDto> GetAll()
        {
            var shortArticle = _repositoryManager.repositoryShortArticle.GetAll();
            var shortArticleDto = shortArticle.Adapt<IEnumerable<ShortArticleDto>>();
            return shortArticleDto;
        }

        public ShortArticleDto GetById(int id)
        {
            if (id == 0)
                return null;

            var shortArticle = _repositoryManager.repositoryShortArticle.GetById(id);
            return shortArticle.Adapt<ShortArticleDto>();
        }

        public void Insert(ShortArticleDto entity)
        {
            var shortArticle = entity.Adapt<ShortArticle>();
            _repositoryManager.repositoryShortArticle.Insert(shortArticle);
            _repositoryManager.UnitOfWork.SaveChanges();

        }

        public void Update(int id)
        {
            _repositoryManager.repositoryShortArticle.Update(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }
    }
}

 