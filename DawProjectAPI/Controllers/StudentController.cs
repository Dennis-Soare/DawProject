using DawProjectAPI.Data;
using DawProjectAPI.Models;
using DawProjectAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DawProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<StudentDTO>> GetStudents()
        {
            return Ok(StudentStore.studentList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<StudentDTO> GetStudent(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var student = StudentStore.studentList.FirstOrDefault(u => u.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);

        }

    }
}
