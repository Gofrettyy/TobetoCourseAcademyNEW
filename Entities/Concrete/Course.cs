using Core.Entities;

namespace Entities.Concrete;

public class Course:Entity<Guid>
{
    public Guid CategoryId { get; set; }
    public Guid InstructorId { get; set; }
    public Category Category { get; set; }
    public Instructor Instructor { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int  Price { get; set; }
    
}