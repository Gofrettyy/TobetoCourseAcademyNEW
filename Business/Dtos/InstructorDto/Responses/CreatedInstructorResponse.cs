namespace Business.Dtos.Responses;

public class CreatedInstructorResponse
{
    public Guid  Id { get; set; }
    public string Name { get; set; }
    public DateTime? CreatedDate { get; set; }
}