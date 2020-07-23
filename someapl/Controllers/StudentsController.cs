using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using someapl.Responses;

namespace someapl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<StudentDto> _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController(IRepository<StudentDto> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentRepository.GetAll();
            return Ok(students);
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var result = _studentRepository.GetById(id);
        //    return Ok(result);
        //}

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _studentRepository.GetById(id);

            var response = new StudentResponse();

            if (result != null)
            {
                response = _mapper.Map<StudentResponse>(result);
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ErrorMessage = "Student not found!";
            }

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create(StudentDto studentDto)
        {
            var result = _studentRepository.Create(studentDto);
            return Ok(result);
        }

        [HttpPut ("{id}")]
        public IActionResult Edit(int id, [FromBody]StudentDto studentDto)
        {
            var result = _studentRepository.Update(id, studentDto);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _studentRepository.Remove(id);
            return Ok(result);
        }
    }
}
