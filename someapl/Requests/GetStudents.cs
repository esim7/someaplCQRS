using System.Collections.Generic;
using Infrastructure.Database.DTO;
using MediatR;

namespace someapl.Requests
{
    public class GetStudents : IRequest<List<StudentDto>>
    {
        
    }
}