using Microsoft.EntityFrameworkCore;
using StudentManagement.Models.StudentNS;

#nullable disable

namespace StudentManagement.API.DataAccess
{
  public partial class StudentDbContext : DbContext
  {

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> students => Set<Student>();

  }
}
