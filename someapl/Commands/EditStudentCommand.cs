using Infrastructure.Database.DTO;
using MediatR;
using someapl.Requests;

namespace someapl.Commands
{
    public class EditStudentCommand : IRequest<StudentDto>
    {
        public int StudentId { get; }
        public StudentDto StudentDto { get; }

        public EditStudentCommand(EditStudentRequest request, StudentDto studentDto)
        {
            StudentId = request.StudentId;
            StudentDto = studentDto;
        }
    }
}