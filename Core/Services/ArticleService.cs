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
    public class ArticleService : IArticleService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ArticleService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public void Delete(int id)
        {
            _repositoryManager.repositoryArticle.Delete(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }

        public IEnumerable<ArticleDto> GetAll()
        {
            var articles = _repositoryManager.repositoryArticle.GetAll();
            return articles.Adapt<IEnumerable<ArticleDto>>();
        }

        public ArticleDto GetById(int id)
        {
            var article = _repositoryManager.repositoryArticle.GetById(id);
            return article.Adapt<ArticleDto>();
        }

        public void Insert(ArticleDto entity)
        {
            var article = entity.Adapt<Article>();
            _repositoryManager.repositoryArticle.Insert(article);
            _repositoryManager.UnitOfWork.SaveChanges();
        }

        public void Update(int id)
        {
            _repositoryManager.repositoryArticle.Update(id);
        }
    }
}
