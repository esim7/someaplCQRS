using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Models;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;

namespace Infrastructure.Database.Implementations
{
    public class CourseRepository : IRepository<CourseDto>
    {
        private readonly SomeContext _context;
        private readonly IMapper _mapper;

        public CourseRepository(SomeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CourseDto GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<CourseDto> GetAll()
        {
            var courses = _context.Courses.ToList();
            var coursesDto = _mapper.Map<List<CourseDto>>(courses);

            return coursesDto;
        }

        public CourseDto Create(CourseDto entity)
        {
            throw new System.NotImplementedException();
        }

        public CourseDto Update(int id, CourseDto entity)
        {
            throw new System.NotImplementedException();
        }

        public CourseDto Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}