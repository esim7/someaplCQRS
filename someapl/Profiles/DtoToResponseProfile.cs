using AutoMapper;
using Infrastructure.Database.DTO;
using someapl.Responses;

namespace someapl.Profiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<StudentDto, StudentResponse>()
                .ForMember(c => c.StudentDto,
                    opt => opt.MapFrom(c => c));
        }
    }
}