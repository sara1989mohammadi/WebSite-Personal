using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryBook : RepositoryBase<Book>, IRepositoryBook
    {
        public RepositoryBook(DataContext context) : base(context)
        {

        }
    }
}