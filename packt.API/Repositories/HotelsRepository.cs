using Microsoft.EntityFrameworkCore;
using packt.API.Contracts;
using packt.API.Data;

namespace packt.API.Repositories
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly PacktApiDBContext _context;

        public HotelsRepository(PacktApiDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Hotel> GetDetails(int id)
        {
            return await _context.Hotels.Include(q => q.Country)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
