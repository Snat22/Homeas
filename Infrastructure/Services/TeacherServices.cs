using Domain.Models;
namespace Infrastructure.Services;

public class TeacherServices
{
         List<Teacher> teachers = new List<Teacher>();

    public List<Teacher> GetTeacher()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
        
    }
    public void UpdateTeacher(Teacher teacher)
    {
           foreach (var s in teachers)
        {
            if(s.Id == teacher.Id)
            {
                s.Firstname = teacher.Firstname;
                s.Lastname = teacher.Lastname;
                s.Experience = teacher.Experience;
            }            
        }
    }
    public void Delete(int id)
    {
        foreach (var s in teachers)
        {
            if(s.Id == id)
            {
                teachers.Remove(s);
            }
        }
        
    }
}
