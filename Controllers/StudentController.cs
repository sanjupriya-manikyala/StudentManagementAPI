using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.StudentManagement.Services.StudentNS.Interface;
using StudentManagement.Models.StudentNS;

namespace StudentManagement.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StudentController : ControllerBase
  {
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
      _studentService = studentService;
    }

    [HttpPost]
    public async Task<IActionResult> AddStudentAsync(Student student)
    {
      try
      {
        return Ok(await _studentService.AddStudentAsync(student));
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
      }
    }
  }
}
