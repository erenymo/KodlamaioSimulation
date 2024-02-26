using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.Business;

public class InstructorManager
{
    private IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }
    
}