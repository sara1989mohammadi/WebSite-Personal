using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IRepositoryActivity repositoryActivity { get; }
        IRepositoryArticle repositoryArticle { get; }
        IRepositoryBiography repositoryBiography { get; }
        IRepositoryBook repositoryBook { get; }
        IRepositoryCV repositoryCV { get; }
        IRepositoryShortArticle repositoryShortArticle { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
