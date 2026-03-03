using Microsoft.EntityFrameworkCore;
using packt.API.Contracts;
using packt.API.Data;

namespace packt.API.Repositories
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly PacktApiDBContext _context;

        public CountriesRepository(PacktApiDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
