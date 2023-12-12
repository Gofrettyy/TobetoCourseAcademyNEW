using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, TobetoCourseAcademyNewContext>, IInstructorDal
{
    public EfInstructorDal(TobetoCourseAcademyNewContext context) : base(context)
    {
    }
}
    
