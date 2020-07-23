using AutoMapper;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;

namespace someapl.Profiles
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<StudentDto, Student>();
        }
    }
}