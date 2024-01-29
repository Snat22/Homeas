using Domain.Models;
namespace Infrastructure.Services;

public class CourseServices
{
     List<Course> courses = new List<Course>();

    public List<Course> GetCourses ()
    {
        return courses;
    }
    public void AddCourse(Course course)
    {
          courses.Add(course);
    }
    public void UpdateStudent(Course course)
    {

        foreach (var s in courses)
        {
            if(s.Id == course.Id)
            {
                s.Title = course.Title;
                s.Description = course.Description;
                s.CreatedAt = course.CreatedAt;
               
            }    
                    
        }
        
    }
    public void Delete(int id)
    {
        foreach (var s in courses)
        {
            if(s.Id == id)
            {
                courses.Remove(s);
            }
        }
    }
}
