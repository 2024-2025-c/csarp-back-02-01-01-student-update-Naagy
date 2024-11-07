using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentRepo;

        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            List<Student>? students = await _studentRepo.GetAll();

            if (students.Any())
            {
                return Ok(students);
            }

            return NotFound("Nincsenek diákok az adatbázisban.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(Guid id)
        {
            var student = await _studentRepo.GetBy(id);
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound("A keresett diák nem található.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(Guid id, [FromBody] Student student)
        {
            var updatedStudent = await _studentRepo.UpdateStudent(id, student);

            if (updatedStudent != null)
            {
                return Ok(updatedStudent);
            }

            return BadRequest("A diák frissítése nem sikerült.");
        }

    }
}
