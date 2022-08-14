using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryActivity : RepositoryBase<Activity>,IRepositoryActivity
    {
        public RepositoryActivity(DataContext context) : base(context)
        {

        }

    }
}
