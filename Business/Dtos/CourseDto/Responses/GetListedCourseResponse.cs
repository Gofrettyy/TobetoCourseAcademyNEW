namespace Business.Dtos.Responses;

public class GetListedCourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
}