using System.ComponentModel.DataAnnotations.Schema;

namespace packt.API.Models.Hotel
{
    public class UpdateHotelDto : BaseHotelDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }

    }
}
    