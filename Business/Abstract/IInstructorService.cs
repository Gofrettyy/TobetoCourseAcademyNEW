using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Abstract;

public interface IInstructorService
{
    Task<Paginate<GetListedInstructorResponse>> GetListAsync();
    Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
    Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
    Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
}