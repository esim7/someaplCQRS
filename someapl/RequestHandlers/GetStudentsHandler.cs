using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Requests;

namespace someapl.RequestHandlers
{
    public class GetStudentsHandler : IRequestHandler<GetStudents, List<StudentDto>>
    {
        private readonly IRepository<StudentDto> _studentRepository;
        private readonly IMapper _mapper;
        

        public GetStudentsHandler(IRepository<StudentDto> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<List<StudentDto>> Handle(GetStudents request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();

            return _mapper.Map<List<StudentDto>>(students);
        }
    }
}