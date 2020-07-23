using System.Collections;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }

        public Student()
        {
            Courses = new HashSet<StudentCourse>();
        }
    }
}