namespace Business.Dtos.Responses;

public class DeletedCategoryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? DeletedDate { get; set; }
}