using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Commands;

namespace someapl.RequestHandlers
{
    public class RemoveStudentRequestHandler : IRequestHandler<RemoveStudentCommand, StudentDto>
    {
        private readonly IRepository<StudentDto> _studentRepository;

        public RemoveStudentRequestHandler(IRepository<StudentDto> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            var removedStudent = _studentRepository.Remove(request.StudentId);
            return removedStudent;
        }
    }
}