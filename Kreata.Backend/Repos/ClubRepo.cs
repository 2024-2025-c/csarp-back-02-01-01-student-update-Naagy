using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class ClubRepo : IClubRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public ClubRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Club>> GetAll()
        {
            return await _dbContext.Clubs.ToListAsync();
        }

        public async Task<Club?> GetBy(Guid id)
        {
            return await _dbContext.Clubs.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<Club?> UpdateClub(Guid id, Club club)
        {
            throw new NotImplementedException();
        }
    }
}
