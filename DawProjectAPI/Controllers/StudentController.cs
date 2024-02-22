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
        public IEnumerable<StudentDTO> GetStudents()
        {
            return StudentStore.studetList;
        }

        [HttpGet("id")]
        public StudentDTO GetStudent(int id)
        {
            return StudentStore.studetList.FirstOrDefault(u => u.Id == id);
        }

    }
}
