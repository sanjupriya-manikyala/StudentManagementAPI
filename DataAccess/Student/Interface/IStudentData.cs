using System.Threading.Tasks;
using StudentManagement.Models.StudentNS;

namespace StudentManagement.API.DataAccess.StudentNS.Interface
{
  public interface IStudentData
  {
    Task<Student> AddStudentAsync(Student student);
  }
}
