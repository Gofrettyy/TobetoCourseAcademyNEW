namespace Business.Dtos.Responses;

public class UpdatedCourseResponse
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public Guid InstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }  
    public DateTime? UpdatedDate { get; set; }
}