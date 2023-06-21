using System.Threading.Tasks;
using StudentManagement.API.DataAccess.StudentNS.Interface;
using StudentManagement.API.StudentManagement.Services.StudentNS.Interface;
using StudentManagement.Models.StudentNS;

namespace StudentManagement.API.StudentManagement.Services.StudentNS
{
  public class StudentService : IStudentService
  {
    private readonly IStudentData _studentData;

    public StudentService(IStudentData studentData)
    {
      _studentData = studentData;
    }
    public virtual async Task<Student> AddStudentAsync(Student student)
    {
      return await _studentData.AddStudentAsync(student);
    }
  }
}
