using System.Threading.Tasks;
using StudentManagement.Models.StudentNS;

namespace StudentManagement.API.StudentManagement.Services.StudentNS.Interface
{
  public interface IStudentService
  {
    Task<Student> AddStudentAsync(Student student);
  }
}
