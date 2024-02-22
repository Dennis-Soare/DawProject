using DawProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DawProjectAPI.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IEnumerable<Student> GetStudents()
        {  
            return new List<Student> { 
                new Student{Id=1, Name="Name 1"} ,
                new Student{Id=2, Name="Name 2"}
            }; 
        }

    }
}
