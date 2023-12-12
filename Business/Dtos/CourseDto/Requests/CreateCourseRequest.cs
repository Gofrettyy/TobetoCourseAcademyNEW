namespace Business.Dtos.Requests;

public class CreateCourseRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string CategoryName { get; set; }
    public string InstructorName { get; set; }
    public int Price { get; set; }  
}