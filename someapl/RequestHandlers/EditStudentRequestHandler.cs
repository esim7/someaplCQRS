using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using someapl.Commands;

namespace someapl.RequestHandlers
{
    public class EditStudentRequestHandler : IRequestHandler<EditStudentCommand, StudentDto>
    {
        private readonly IRepository<StudentDto> _studentRepository;

        public EditStudentRequestHandler(IRepository<StudentDto> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _studentRepository.Update(request.StudentId, request.StudentDto);
            return student;
        }
    }
}