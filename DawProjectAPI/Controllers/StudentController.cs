using DawProjectAPI.Data;
using DawProjectAPI.Models;
using DawProjectAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;

namespace DawProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<StudentDTO>> GetStudents()
        {
            return Ok(_db.Students.ToList());
        }

        [HttpGet("{id:int}",Name = "GetStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<StudentDTO> GetStudent(Guid id)
        {
            var student = _db.Students.FirstOrDefault(u => u.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateS (Student student)
        {

            await _db.AddAsync(student);
            await _db.SaveChangesAsync();

            return Ok(student);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<StudentDTO> CreateStudent([FromBody] StudentDTO student)
        {
            if (student == null)
            {
                return BadRequest(student);
            }
            if (student.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            student.Id = StudentStore.studentList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            StudentStore.studentList.Add(student);

            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }

        [HttpDelete]
        public ActionResult Delete(StudentDTO student)
        {
            StudentStore.studentList.Remove(student);
            return Ok(StudentStore.studentList);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StudentDTO s)
        {
            var studentId = StudentStore.studentList.FindIndex((StudentDTO _student) =>
            _student.Id.Equals(s.Id));
            StudentStore.studentList[studentId] = s;
            return Ok(s);
        }
    }
}
