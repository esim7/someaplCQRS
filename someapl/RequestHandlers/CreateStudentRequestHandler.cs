using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Commands;

namespace someapl.RequestHandlers
{
    public class CreateStudentRequestHandler : IRequestHandler<CreateStudentCommand, StudentDto>
    {
        private readonly IRepository<StudentDto> _studentRepository;

        public CreateStudentRequestHandler(IRepository<StudentDto> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var createdStudent = _studentRepository.Create(request.StudentDto);
            return createdStudent;
        }
    }
}