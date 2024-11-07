using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : ControllerBase
    {
        private IParentRepo _parentRepo;

        public ParentController(IParentRepo parentRepo)
        {
            _parentRepo = parentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllParents()
        {
            var parents = await _parentRepo.GetAll();

            if (parents.Any())
            {
                return Ok(parents);
            }

            return NotFound("Nincsenek szülők az adatbázisban.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParentById(Guid id)
        {
            var parent = await _parentRepo.GetBy(id);
            if (parent != null)
            {
                return Ok(parent);
            }

            return NotFound("A keresett szülő nem található.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateParent(Guid id, [FromBody] Parent parent)
        {
            var updatedParent = await _parentRepo.UpdateParent(id, parent);

            if (updatedParent != null)
            {
                return Ok(updatedParent);
            }

            return BadRequest("A szülő frissítése nem sikerült.");
        }
    }
}
