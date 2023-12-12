namespace Business.Dtos.Responses;

public class CreatedCourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime? CreatedDate { get; set; }
}