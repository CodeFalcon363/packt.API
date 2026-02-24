using Microsoft.EntityFrameworkCore;

namespace packt.API.Data
{
    public class PacktApiDBContext : DbContext
    {
        public PacktApiDBContext(DbContextOptions<PacktApiDBContext> options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United States",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    ShortName = "CA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Mexico",
                    ShortName = "MX"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Hotel California",
                        Address = "42 Sunset Boulevard",
                        City = "Los Angeles",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Maple Leaf Inn",
                        Address = "123 Maple Street",
                        City = "Toronto",
                        CountryId = 2,
                        Rating = 4.0
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Casa del Sol",
                        Address = "456 Playa Avenue",
                        City = "Cancun",
                        CountryId = 3,
                        Rating = 4.2
                    }
                );
        }
    }
}
