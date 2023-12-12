using Core.Entities;

namespace Entities.Concrete;

public class Instructor:Entity<Guid>
{
    public List<Course>? Courses { get; set; }
    public string Name { get; set; }
}