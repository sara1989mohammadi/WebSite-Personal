using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IServiceManager
    {
        IActivityService ActivityService { get; }
        IArticleService ArticleService { get; }
        IBiographyService BiographyService { get; }
        IBookService BookService { get; }
        ICVService CVService { get; }
        IShortArticleService ShortArticleService { get; }

    }
}
