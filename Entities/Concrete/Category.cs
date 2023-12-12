using Core.Entities;

namespace Entities.Concrete;

public class Category:Entity<Guid>
{
    public string Name { get; set; }
    public List<Course>? Courses { get; set; }
}