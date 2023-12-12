using System.Data.Common;

namespace Business.Dtos.Requests;

public class UpdateInstructorRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}