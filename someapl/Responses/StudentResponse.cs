using System.Net;
using Infrastructure.Database.DTO;

namespace someapl.Responses
{
    public class StudentResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public StudentDto StudentDto { get; set; }
        public string ErrorMessage { get; set; }
    }
}