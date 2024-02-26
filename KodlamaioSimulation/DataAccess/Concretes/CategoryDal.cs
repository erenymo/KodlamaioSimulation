using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;

namespace KodlamaioSimulation.DataAccess.Concretes;

public class CategoryDal:ICategoryDal
{
    private List<Category> _categories;

    public CategoryDal()
    {
        _categories = new List<Category>
        {
            new Category{Id = 1, Name = "Programlama"}
        };
    }

    public void Add(Category category)
    {
        _categories.Add(category);
        Console.WriteLine($"Kategori başarıyla eklendi : {category.Name}");
    }
    
    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
        Console.WriteLine($"Kategori başarıyla silindi : {category.Name}");
    }

    public void Update(Category category)
    {
        Console.WriteLine("Kategori güncellendi");
    }
}