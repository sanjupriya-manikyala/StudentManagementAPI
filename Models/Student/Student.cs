using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.StudentNS
{
  public class Student
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
    public string Year { get; set; }
    public string Section { get; set; }

  }
}
