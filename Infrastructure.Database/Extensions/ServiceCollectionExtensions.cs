using AutoMapper;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Implementations;
using Infrastructure.Database.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Database.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository<StudentDto>, StudentRepository>();
            services.AddScoped<IRepository<CourseDto>, CourseRepository>();
            return services;
        }
    }
}