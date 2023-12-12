using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    Task<Paginate<GetListedCourseResponse>> GetListAsync();
    Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
    Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest);
    Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest);
}