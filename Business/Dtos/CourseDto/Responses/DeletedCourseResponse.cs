namespace Business.Dtos.Responses;

public class DeletedCourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? DeletedDate { get; set; }
}