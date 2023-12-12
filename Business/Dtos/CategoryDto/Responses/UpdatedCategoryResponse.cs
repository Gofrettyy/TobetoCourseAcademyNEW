namespace Business.Dtos.Responses;

public class UpdatedCategoryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? UpdatedDate { get; set; }
}