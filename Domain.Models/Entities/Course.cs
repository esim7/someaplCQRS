using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<StudentCourse> Students { get; set; }

        public Course()
        {
            Students = new HashSet<StudentCourse>();
        }
    }
}
