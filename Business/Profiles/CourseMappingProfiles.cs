using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Profiles;

public class CourseMappingProfiles:Profile
{
    public CourseMappingProfiles()
    {
        CreateMap<Course, CreateCourseRequest>().ReverseMap();
        CreateMap<Course, CreatedCourseResponse>().ReverseMap();
        CreateMap<Course, GetListedCourseResponse>().ReverseMap();
        CreateMap<Paginate<Course>, Paginate<GetListedCourseResponse>>().ReverseMap();
        CreateMap<Course, DeleteCourseRequest>().ReverseMap();
        CreateMap<Course, DeletedCourseResponse>().ReverseMap();
        CreateMap<Course,UpdateCourseRequest>().ReverseMap();
        CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
        CreateMap<Paginate<Instructor>, Paginate<GetListedInstructorResponse>>().ReverseMap();
    }
}