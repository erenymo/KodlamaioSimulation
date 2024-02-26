using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Abstracts;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor);
}