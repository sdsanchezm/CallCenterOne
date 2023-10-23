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
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Store)
                .WithOne(s => s.Customer)
                .HasForeignKey<Store>(c => c.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.City) // this City is from the customer Model
                .WithOne(s => s.Customer) // this customer is from the city Model
                .HasForeignKey<City>(c => c.CustomerId); // This CustomerId is from the StoreModel

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Country)
                .WithOne(co => co.Customer)
                .HasForeignKey<Country>(c => c.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Priority1)
                .WithOne(pr => pr.Customer)
                .HasForeignKey<Priority>(c => c.CustomerId);

        }

    }
}
