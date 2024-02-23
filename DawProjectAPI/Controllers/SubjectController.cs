using DawProjectAPI.Data;
using DawProjectAPI.Models;
using DawProjectAPI.Models.DTOs;
using DawProjectAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DawProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService _subjectService;

        [HttpPost("CreateSubject")]
        public async Task<IActionResult> CreateSubject(Subject s)
        {
            _subjectService.CreateNewSubject(s);
            return Ok();
        }

        [HttpGet("getSubjects")]
        public IActionResult GetSubjects()
        {
            return Ok(_subjectService.GetAllSubjects());
        }
    }
}
