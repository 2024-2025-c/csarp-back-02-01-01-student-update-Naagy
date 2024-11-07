using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly IClubRepo _clubRepo;

        public ClubController(IClubRepo clubRepo)
        {
            _clubRepo = clubRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClubs()
        {
            List<Club>? clubs = await _clubRepo.GetAll();

            if (clubs.Any())
            {
                return Ok(clubs);
            }

            return NotFound("Nincsenek csapatok az adatbázisban.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClubById(Guid id)
        {
            var club = await _clubRepo.GetBy(id);
            if (club != null)
            {
                return Ok(club);
            }

            return NotFound("A keresett csapat nem található.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClub(Guid id, [FromBody] Club club)
        {
            var updatedClub = await _clubRepo.UpdateClub(id, club);

            if (updatedClub != null)
            {
                return Ok(updatedClub);
            }

            return BadRequest("A csapat frissítése nem sikerült.");
        }

    }
}
