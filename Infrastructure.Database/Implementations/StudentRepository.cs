using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Models;
using Domain.Models.Entities;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;

namespace Infrastructure.Database.Implementations
{
    public class StudentRepository : IRepository<StudentDto>
    {
        private readonly SomeContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(SomeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public StudentDto GetById(int id)
        {
            var student = _context.Students.Find(id);
            return _mapper.Map<StudentDto>(student);
        }

        public IList<StudentDto> GetAll()
        {
            var students = _context.Students.ToList();
            var studentsDto = _mapper.Map<List<StudentDto>>(students);

            return studentsDto;
        }

        public StudentDto Create(StudentDto entity)
        {
            var student = _mapper.Map<Student>(entity);

            var addedStudent = _context.Students.Add(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(addedStudent.Entity);
        }

        public StudentDto Update(int id, StudentDto entity)
        {
            var student = _context.Students.Find(id);

            student.Name = entity.Name;

            _context.Students.Update(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(student);
        }

        public StudentDto Remove(int id)
        {
            var student = _context.Students.Find(id);

            _context.Students.Remove(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(student);
        }
    }
}