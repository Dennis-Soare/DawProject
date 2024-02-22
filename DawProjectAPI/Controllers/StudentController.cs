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

    }
}
