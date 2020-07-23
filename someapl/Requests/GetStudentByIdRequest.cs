using Infrastructure.Database.DTO;
using MediatR;

namespace someapl.Requests
{
    public class GetStudentByIdRequest : IRequest<StudentDto>
    {
        public int StudentId { get;}
        public GetStudentByIdRequest(int id)
        {
            StudentId = id;
        }
    }
}