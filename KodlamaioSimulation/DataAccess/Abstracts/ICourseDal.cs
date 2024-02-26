using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);
}