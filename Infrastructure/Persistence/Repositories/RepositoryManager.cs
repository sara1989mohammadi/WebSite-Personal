using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IRepositoryActivity> _lazyRepositoryActivity;
        private readonly Lazy<IRepositoryArticle> _lazyRepositoryArticle;
        private readonly Lazy<IRepositoryBiography> _lazyRepositoryBiography;
        private readonly Lazy<IRepositoryBook> _lazyRepositoryBook;
        private readonly Lazy<IRepositoryCV> _lazyRepositoryCV;
        private readonly Lazy<IRepositoryShortArticle> _lazyRepositoryShortArticle;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(DataContext dbContext)
        {
            _lazyRepositoryActivity = new Lazy<IRepositoryActivity>(() => new RepositoryActivity(dbContext));
            _lazyRepositoryArticle = new Lazy<IRepositoryArticle>(() => new RepositoryArticle(dbContext));
            _lazyRepositoryBiography = new Lazy<IRepositoryBiography>(() => new RepositoryBiography(dbContext));
            _lazyRepositoryBook = new Lazy<IRepositoryBook>(() => new RepositoryBook(dbContext));
            _lazyRepositoryCV = new Lazy<IRepositoryCV>(() => new RepositoryCV(dbContext));
            _lazyRepositoryShortArticle = new Lazy<IRepositoryShortArticle>(() => new RepositoryShortArticle(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }       

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
        public IRepositoryActivity repositoryActivity => _lazyRepositoryActivity.Value;
        public IRepositoryArticle repositoryArticle => _lazyRepositoryArticle.Value;
        public IRepositoryBiography repositoryBiography => _lazyRepositoryBiography.Value;
        public IRepositoryBook repositoryBook => _lazyRepositoryBook.Value;
        public IRepositoryCV repositoryCV => _lazyRepositoryCV.Value;
        public IRepositoryShortArticle repositoryShortArticle => _lazyRepositoryShortArticle.Value;
    }
}

