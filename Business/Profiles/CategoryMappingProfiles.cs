using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Profiles;

public class CategoryMappingProfiles:Profile
{
    public CategoryMappingProfiles()
    {
        CreateMap<Category, DeleteCategoryRequest>().ReverseMap();
        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();
        CreateMap<Category,UpdateCategoryRequest>().ReverseMap();
        CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
        CreateMap<Category, GetListedCategoryResponse>().ReverseMap();
        CreateMap<Paginate<Category>, Paginate<GetListedCategoryResponse>>().ReverseMap();
    }
    
}