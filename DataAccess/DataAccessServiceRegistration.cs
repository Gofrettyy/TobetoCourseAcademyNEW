using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration) 
    { //services.AddDbContext<TobetoCourseAcademyNewContext>(options=>options.UseInMemoryDatabase("nArchitecture"));
services.AddDbContext<TobetoCourseAcademyNewContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoCourseDb")));
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICourseDal, EfCourseDal>();
        services.AddScoped<IInstructorDal, EfInstructorDal>();
        
        return services; }
}