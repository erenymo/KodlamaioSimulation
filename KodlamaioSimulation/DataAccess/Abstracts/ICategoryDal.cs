using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Delete(Category category);
    void Update(Category category);
}