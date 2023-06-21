using System.Threading.Tasks;
using StudentManagement.API.DataAccess.StudentNS.Interface;
using StudentManagement.Models.StudentNS;

namespace StudentManagement.API.DataAccess.StudentNS
{
  public class StudentData : IStudentData
  {
    private readonly StudentDbContext _dbContext;
    public StudentData(StudentDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    public async Task<Student> AddStudentAsync(Student student)
    {
      var result = await _dbContext.AddAsync(student);
      await _dbContext.SaveChangesAsync();
      return result.Entity;
    }
  }
}
