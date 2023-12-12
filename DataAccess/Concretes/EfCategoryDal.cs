using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class EfCategoryDal:EfRepositoryBase<Category,Guid,TobetoCourseAcademyNewContext>,ICategoryDal
{
    public EfCategoryDal(TobetoCourseAcademyNewContext context) : base(context)
    {
    }
}
