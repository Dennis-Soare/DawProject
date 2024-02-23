using DawProjectAPI.Models;
using DawProjectAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DawProjectAPI.Controllers
{
    public class BookController : ControllerBase
    {
        private readonly SubjectService _subjectService;

        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateBook(Book b)
        {
            _subjectService.CreateNewBook(b);
            return Ok();
        }

        [HttpGet("getBooks")]
        public IActionResult GetBooks()
        {
            return Ok(_subjectService.GetAllBooks());
        }
    }
}
