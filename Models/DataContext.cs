using KarmaT.Models.Blog;
using Microsoft.EntityFrameworkCore;

namespace KarmaT.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogCategoriaArea> BlogCategoriaArea1 { get; set; }

    }
}
