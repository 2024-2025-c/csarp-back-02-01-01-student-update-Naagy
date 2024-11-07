using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IClubRepo
    {
        Task<List<Club>> GetAll();
        Task<Club?> GetBy(Guid id);
        Task<Club?> UpdateClub(Guid id, Club club);
    }
}
