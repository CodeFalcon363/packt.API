using System.ComponentModel.DataAnnotations.Schema;

namespace packt.API.Models.Hotel
{
    public class GetHotelDto : BaseHotelDto
    {
        public int Id { get; set; }
        public CountryDetailDto Country { get; set; }

    }
}
