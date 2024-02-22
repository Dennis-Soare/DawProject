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
            return new List<StudentDTO> { 
                new StudentDTO{Id=1, Name="Name 1"} ,
                new StudentDTO{Id=2, Name="Name 2"}
            }; 
        }

    }
}
