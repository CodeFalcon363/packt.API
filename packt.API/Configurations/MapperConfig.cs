using AutoMapper;
using packt.API.Data;
using packt.API.Models.Country;
using packt.API.Models.Hotel;
using packt.API.Models.User;

namespace packt.API.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap();
        CreateMap<Country, GetCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Hotel, HotelDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();

        CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        CreateMap<Hotel, GetHotelDto>().ReverseMap();
        CreateMap<Hotel, HotelDetailDto>().ReverseMap();
        CreateMap<Country, CountryDetailDto>().ReverseMap();
        CreateMap<Hotel, UpdateHotelDto>().ReverseMap();

        CreateMap<ApiUserDto, ApiUser>().ReverseMap();

    }
}

