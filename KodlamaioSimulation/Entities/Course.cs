namespace KodlamaioSimulation.Entities;

public class Course
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}