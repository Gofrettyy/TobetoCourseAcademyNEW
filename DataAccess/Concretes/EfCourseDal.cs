using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class EfCourseDal:EfRepositoryBase<Course,Guid,TobetoCourseAcademyNewContext>,ICourseDal

{
    public EfCourseDal(TobetoCourseAcademyNewContext context) : base(context)
    {
    }
}