using System.Data.Common;

namespace PracticeApp
{
    public interface IStudentService
    {
        Student GetStudentById(int id);
        List<Student> GetAllStudents();
        
    }
    public class StudentService : IStudentService
    {
        List<Student> students = new List<Student>
        {
            new Student{
                Id=1,
                Name = "ashok",
                Address = "khammam"
            },
            new Student{
                Id=2,
                Name = "kethan",
                Address = "warangal"
            }
        };
         public Student GetStudentById(int id)
         {
            return students.Find(s=>s.Id==id);
         }
         public List<Student> GetAllStudents()
         {
            return students;
         }
        
    }
    public class StudentServiceFromDB : IStudentService
    {
        List<Student> students = new List<Student>
        {
            new Student{
                Id=1,
                Name = "ashok",
                Address = "khammam"
            },
            new Student{
                Id=2,
                Name = "kethan",
                Address = "warangal"
            }
        };
         public Student GetStudentById(int id)
         {
            return students.Find(s=>s.Id==id);
         }
         public List<Student> GetAllStudents()
         {
            return students;
         }
        
    }
}