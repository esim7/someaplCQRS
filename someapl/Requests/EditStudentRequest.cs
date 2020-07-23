using Infrastructure.Database.DTO;
using MediatR;

namespace someapl.Requests
{
    public class EditStudentRequest : IRequest<StudentDto>
    {
        public int StudentId { get; }
        public EditStudentRequest(int id)
        {
            StudentId = id;
        }
    }
}