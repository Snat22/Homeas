using Domain.Models;
namespace Infrastructure.Services;

public class StudentServices
{
         List<Student> students = new List<Student>();

    public List<Student> GetStudent ()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
       students.Add(student);   
    }
    public void UpdateStudent(Student student)
    {
          foreach (var s in students)
        {
            if(s.Id == student.Id)
            {
                s.Firstname = student.Firstname;
                s.Lastname = student.Lastname;
                s.Address = student.Address;
                 System.Console.WriteLine("Updated Sucessfully");
                break;
            }  
            System.Console.WriteLine("Student NOt Found");          
        }
    }
    public void Delete(int id)
    {
        foreach (var s in students)
        {
            if(s.Id == id)
            {
                students.Remove(s);
            }
        }
    }
}
