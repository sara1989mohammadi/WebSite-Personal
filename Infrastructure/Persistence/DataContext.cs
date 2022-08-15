using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public partial  class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Biography> Biography { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<CV> CV { get; set; }
        public DbSet<ShortArticle> ShortArticle { get; set; }       
    }
}
