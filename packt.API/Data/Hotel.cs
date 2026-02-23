using System.ComponentModel.DataAnnotations.Schema;

namespace packt.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
            public Country Country { get; set; }
    }
}
