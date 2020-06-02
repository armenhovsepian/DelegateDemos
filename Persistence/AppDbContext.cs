using Microsoft.EntityFrameworkCore;
using Persistence.Model;

namespace Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
