using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Profiles;

public class InstructorMappingProfiles:Profile
{
    public InstructorMappingProfiles()
    {
        CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
        CreateMap<Instructor, DeletedInstructorResponse>().ReverseMap();
        CreateMap<Instructor,UpdateInstructorRequest>().ReverseMap();
        CreateMap<Instructor, UpdatedInstructorResponse>().ReverseMap();
        CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
        CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
        CreateMap<Instructor, GetListedInstructorResponse>().ReverseMap();
        CreateMap<Paginate<Instructor>, Paginate<GetListedInstructorResponse>>().ReverseMap(); 
    }
    
}