using Microsoft.EntityFrameworkCore;
using SalesCet107.Web.Data.Entities;

namespace SalesCet107.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        { 
        }


        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<State>()
                .HasIndex(s => new { s.CountryId, s.Name })
                .IsUnique();
            modelBuilder.Entity<City>()
                .HasIndex(c => new { c.StateId, c.Name })
                .IsUnique();
        }
    }
}
