using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace someapl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepository<CourseDto> _courseRepository;

        public CoursesController(IRepository<CourseDto> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IActionResult Get()
        {
            var courses = _courseRepository.GetAll();
            return Ok(courses);
        }
    }
}
