using KodlamaioSimulation.Business;
using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.DataAccess.Concretes;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation;

class Program
{
    static void Main(string[] args)
    {
        #region Course
        Console.WriteLine("#### Course Manager ####");
        ICourseDal courseDal = new CourseDal();
        Course js = new Course
            { Id = 6, CategoryId = 2, InstructorId = 2, Title = "JavaScript ve React kursu", Price = 0 };
        courseDal.Add(js); // adding new course into the courses
        
        CourseManager courseManager = new CourseManager(courseDal);
        List<Course> courses = courseManager.GetAll();
        ShowCourseList(courses);
        
        courseDal.Delete(js); // deleting course from the courses
        courseDal.Update(js);
        ShowCourseList(courses);
        
        #endregion

        #region Category
        Console.WriteLine($"\n\n#### Category Manager ####");
        ICategoryDal categoryDal = new CategoryDal();
        Category category2 = new Category { Id = 2, Name = "Oyun geliştirme" };
        categoryDal.Add(category2);

        CategoryManager categoryManager = new CategoryManager(categoryDal);
        List<Category> categories = categoryManager.GetAll();
        ShowCategoryList(categories);

        
        categoryDal.Delete(category2);
        categoryDal.Update(category2);
        ShowCategoryList(categories);
        #endregion

        #region Instructor
        Console.WriteLine($"\n\n#### Instructor Manager ####");
        IInstructorDal instructorDal = new InstructorDal();
        Instructor instructor2 = new Instructor { FirstName = "Şulenur", LastName = "BALTA", Id = 3};
        instructorDal.Add(instructor2);

        InstructorManager instructorManager = new InstructorManager(instructorDal);
        List<Instructor> instructors = instructorManager.GetAll();
        ShowInstructorList(instructors);
        
        
        instructorDal.Delete(instructor2);
        instructorDal.Update(instructor2);
        ShowInstructorList(instructors);
        #endregion

    }

    static void ShowCourseList(List<Course> courses)
    {
        foreach (var course in courses)
        {
            Console.WriteLine(course.Title);
        }
    }
    
    static void ShowCategoryList(List<Category> categories)
    {
        foreach (var category in categories)
        {
            Console.WriteLine(category.Name);
        }
    }
    
    static void ShowInstructorList(List<Instructor> instructors)
    {
        foreach (var instructor in instructors)
        {
            Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
        }
    }
}