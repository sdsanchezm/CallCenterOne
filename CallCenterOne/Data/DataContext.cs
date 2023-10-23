using CallCenterOne.Models;
using Microsoft.EntityFrameworkCore;

namespace CallCenterOne.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Customer> CustomerDbSet { get; set; }
        public DbSet<Country> CountryDbSet { get; set; }
        public DbSet<City> CityDbSet { get; set; }
        public DbSet<Priority> PriorityDbSet { get; set; }
        public DbSet<Store> StoreDbSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<City>().HasKey(p => new { p.Id, })
        }

    }
}
