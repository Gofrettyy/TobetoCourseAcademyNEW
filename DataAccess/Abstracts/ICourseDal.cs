using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICourseDal:IRepository<Course,Guid>,IAsyncRepository<Course,Guid>
{
    
}