using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Concretes;

public class InstructorDal:IInstructorDal
{
    private List<Instructor> _instructors;

    public InstructorDal()
    {
        _instructors = new List<Instructor>
        {
            new Instructor{FirstName = "Engin", LastName = "DEMIROG", Id = 1},
            new Instructor{FirstName = "Eren", LastName = "BALTA", Id = 2}
        };
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
        Console.WriteLine($"Eğitmen başarıyla eklendi : {instructor.FirstName} {instructor.LastName}");
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
        Console.WriteLine($"Eğitmen başarıyla silindi : {instructor.FirstName} {instructor.LastName}");
    }

    public void Update(Instructor instructor)
    {
        Console.WriteLine($"Eğitmen başarıyla güncellendi : {instructor.FirstName} {instructor.LastName}");
    }
}