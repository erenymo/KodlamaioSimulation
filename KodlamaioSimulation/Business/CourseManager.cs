using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.Business;

public class CourseManager
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // Business Layer
        return _courseDal.GetAll();
    }
}