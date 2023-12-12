using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class BusinessServiceRegistration 
{ public static IServiceCollection AddBusinessServices(this IServiceCollection services) 
{ services.AddScoped<ICategoryService, CategoryManager>();
    services.AddScoped<ICourseService, CourseManager>();
    services.AddScoped<IInstructorService, InstructorManager>();
    return services; } }