using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;
public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;
    private IMapper _mapper;

    public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
    {
        _instructorDal = instructorDal;
        _mapper = mapper;
    }

    public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
    {
        Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
        Instructor createdInstructor = await _instructorDal.AddAsync(instructor);
        CreatedInstructorResponse createdInstructorResponse = new CreatedInstructorResponse();
        createdInstructorResponse.Id = createdInstructor.Id;
        return createdInstructorResponse;
    }

    public async Task<Paginate<GetListedInstructorResponse>> GetListAsync()
    {
        var result = await _instructorDal.GetListAsync();
        var getListedInstructorResponse = _mapper.Map<Paginate<GetListedInstructorResponse>>(result);
        foreach (var item in getListedInstructorResponse.Items)
        {
            _mapper.Map<Instructor>(item);
        }
        return getListedInstructorResponse;
    }
    public async Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest)
    {
        Instructor deleteInstructor = await _instructorDal.GetAsync(i => i.Id == deleteInstructorRequest.Id);
        await _instructorDal.DeleteAsync(deleteInstructor);
        return _mapper.Map<DeletedInstructorResponse>(deleteInstructor);
    }
    public async Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
    {
        Instructor updateInstructor = await _instructorDal.GetAsync(i => i.Id == updateInstructorRequest.Id);
        _mapper.Map(updateInstructorRequest, updateInstructor);
        Instructor updatedInstructor = await _instructorDal.UpdateAsync(updateInstructor);
        return _mapper.Map<UpdatedInstructorResponse>(updatedInstructor );
    }

}