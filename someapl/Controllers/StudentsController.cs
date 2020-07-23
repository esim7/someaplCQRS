using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using someapl.Requests;
using someapl.Responses;

namespace someapl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<StudentDto> _studentRepository;
        private readonly IMediator _mediator;

        public StudentsController(IRepository<StudentDto> studentRepository, IMediator mediator)
        {
            _studentRepository = studentRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var request = new GetStudents();
            var response = _mediator.Send(request);

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var request = new GetStudentById();
            var response = _mediator.Send(request);

            return Ok(response.Result);

            var result = _studentRepository.GetById(id);
            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var result = _studentRepository.GetById(id);

        //    var response = new StudentResponse();

        //    if (result != null)
        //    {
        //        response = _mapper.Map<StudentResponse>(result);
        //        response.StatusCode = HttpStatusCode.OK;
        //    }
        //    else
        //    {
        //        response.StatusCode = HttpStatusCode.NotFound;
        //        response.ErrorMessage = "Student not found!";
        //    }

        //    return Ok(response);
        //}

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
