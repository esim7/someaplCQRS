using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Requests;

namespace someapl.RequestHandlers
{
    public class GetStudentByIdRequestHandler : IRequestHandler<GetStudentByIdRequest, StudentDto>
    {
        private readonly IRepository<StudentDto> _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentByIdRequestHandler(IRepository<StudentDto> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDto> Handle(GetStudentByIdRequest request, CancellationToken cancellationToken)
        {
            var result = _studentRepository.GetById(request.StudentId);
            return result;
        }
    }
}