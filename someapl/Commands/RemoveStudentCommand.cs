using Infrastructure.Database.DTO;
using MediatR;

namespace someapl.Commands
{
    public class RemoveStudentCommand : IRequest<StudentDto>
    {
        public int StudentId { get; }
        public RemoveStudentCommand(int id)
        {
            StudentId = id;
        }
    }
}