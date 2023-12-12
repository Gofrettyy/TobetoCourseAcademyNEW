using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICategoryService
{
    Task<Paginate<GetListedCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
    Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);

}