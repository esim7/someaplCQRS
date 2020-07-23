using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Requests;

namespace someapl.RequestHandlers
{
    public class GetStudentsRequestHandler : IRequestHandler<GetStudentsRequest, List<StudentDto>>
    {
        private readonly IRepository<StudentDto> _studentRepository;


        public GetStudentsRequestHandler(IRepository<StudentDto> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDto>> Handle(GetStudentsRequest request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();

            return students as List<StudentDto>;
        }
    }
}