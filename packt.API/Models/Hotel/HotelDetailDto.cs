
namespace packt.API.Models.Hotel
{
    public class HotelDetailDto : BaseHotelDto
    {
        public int Id { get; set; }
       public CountryDetailDto Country { get; set; }
    }
}
