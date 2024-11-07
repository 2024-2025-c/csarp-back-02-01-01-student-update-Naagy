using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepo _teacherRepo;

        public TeacherController(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            List<Teacher>? teachers = await _teacherRepo.GetAll();

            if (teachers.Any())
            {
                return Ok(teachers);
            }

            return NotFound("Nincsenek tanárok az adatbázisban.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacherById(Guid id)
        {
            var teacher = await _teacherRepo.GetBy(id);
            if (teacher != null)
            {
                return Ok(teacher);
            }

            return NotFound("A keresett tanár nem található.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] Teacher teacher)
        {
            var updatedTeacher = await _teacherRepo.UpdateTeacher(id, teacher);

            if (updatedTeacher != null)
            {
                return Ok(updatedTeacher);
            }

            return BadRequest("A tanár frissítése nem sikerült.");
        }

    }
}
