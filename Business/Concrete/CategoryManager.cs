using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager:ICategoryService
{
   
    private ICategoryDal _categoryDal;
    private IMapper _mapper;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        Category category = _mapper.Map<Category>(createCategoryRequest);
        Category createdCategory = await _categoryDal.AddAsync(category);
        CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
        createdCategoryResponse.Id = createdCategory.Id;
        return createdCategoryResponse;
    }

    public async Task<Paginate<GetListedCategoryResponse>> GetListAsync()
    {
        var result = await _categoryDal.GetListAsync();
        var getListedCategoryResponse = _mapper.Map<Paginate<GetListedCategoryResponse>>(result);
        foreach (var item in getListedCategoryResponse.Items)
        {
            _mapper.Map<Category>(item);
        }
        return getListedCategoryResponse;
    }
    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category deleteCategory = await _categoryDal.GetAsync(c => c.Id == deleteCategoryRequest.Id);
        await _categoryDal.DeleteAsync(deleteCategory);
        return _mapper.Map<DeletedCategoryResponse>(deleteCategory);
    }
    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        Category updateCategory = await _categoryDal.GetAsync(c => c.Id == updateCategoryRequest.Id);
        _mapper.Map(updateCategoryRequest, updateCategory);
        Category updatedCategory = await _categoryDal.UpdateAsync(updateCategory);
        return _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
    }

}