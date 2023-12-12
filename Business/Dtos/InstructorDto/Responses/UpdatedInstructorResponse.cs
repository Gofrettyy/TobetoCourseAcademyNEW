namespace Business.Dtos.Responses;

public class UpdatedInstructorResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? UpdatedDate { get; set; }
}