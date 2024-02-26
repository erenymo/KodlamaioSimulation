using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    private List<Course> _courses;

    public CourseDal()
    {
        _courses = new List<Course>
        {
            new Course{Id = 1, CategoryId = 1, InstructorId = 1, Title = "C# .NET 8 kursu", Price = 0},
            new Course{Id = 2, CategoryId = 1, InstructorId = 1, Title = "JAVA Spring Boot kursu", Price = 0},
            new Course{Id = 3, CategoryId = 1, InstructorId = 2, Title = "Python Selenium kursu", Price = 0},
        };
    }

    public List<Course> GetAll()
    {
        return _courses;
    }
    
    public void Add(Course course)
    {
        _courses.Add(course);
        Console.WriteLine($"Kurs başarıyla eklendi : {course.Title}");
    }

    public void Update(Course course)
    {
        Console.WriteLine($"Kurs fiyatı başarıyla güncellendi : {course.Title}");
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
        Console.WriteLine($"Kurs başarıyla silindi : {course.Title}");
    }
}