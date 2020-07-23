using System.Collections;
using System.Collections.Generic;

namespace Infrastructure.Database.DTO
{
    public class SchoolDto
    {
        public IList<StudentDto> Students { get; set; }
        public IList<CourseDto> Courses { get; set; }
    }
}