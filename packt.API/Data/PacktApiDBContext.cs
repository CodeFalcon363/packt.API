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
    }
}
