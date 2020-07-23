using Infrastructure.Database.DTO;
using MediatR;

namespace someapl.Commands
{
    public class CreateStudentCommand : IRequest<StudentDto>
    {
        public StudentDto StudentDto { get; }
        public CreateStudentCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}