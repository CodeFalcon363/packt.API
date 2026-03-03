using packt.API.Data;

namespace packt.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id); 
    }


}
