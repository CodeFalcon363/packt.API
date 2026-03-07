using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace packt.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
