using AutoMapper;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;

namespace someapl.Profiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Course, CourseDto>();
        }
    }
}