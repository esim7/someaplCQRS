﻿using System;

namespace Infrastructure.Database.DTO
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}