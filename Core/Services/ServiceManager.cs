using Domain.Repositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager: IServiceManager
    {
        private readonly Lazy<IActivityService> _lazyctivityService;
        private readonly Lazy<IArticleService> _lazyArticleService;
        private readonly Lazy<IBiographyService> _lazyBiographyService;
        private readonly Lazy<IBookService> _lazyBookService;
        private readonly Lazy<ICVService> _lazyCVService;
        private readonly Lazy<IShortArticleService> _lazyShortArticleService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyctivityService = new Lazy<IActivityService>(() => new ActivityService(repositoryManager));
            _lazyArticleService = new Lazy<IArticleService>(() => new ArticleService(repositoryManager));
            _lazyBiographyService = new Lazy<IBiographyService>(() => new BiographyService(repositoryManager));
            _lazyCVService = new Lazy<ICVService>(() => new CVService(repositoryManager));
            _lazyBookService = new Lazy<IBookService>(() => new BookService(repositoryManager));
            _lazyShortArticleService = new Lazy<IShortArticleService>(() => new ShortArticleService(repositoryManager));
        }

        public IActivityService ActivityService => _lazyctivityService.Value;

        public IArticleService ArticleService => _lazyArticleService.Value;

        public IBiographyService BiographyService => _lazyBiographyService.Value;

        public ICVService CVService => _lazyCVService.Value;
        public IBookService BookService => _lazyBookService.Value;

        public IShortArticleService ShortArticleService => _lazyShortArticleService.Value;
    }
}
