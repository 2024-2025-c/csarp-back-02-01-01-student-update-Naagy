﻿using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public StudentRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<Student?> GetBy(Guid id)
        {
            return await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Student?> UpdateStudent(Guid id, Student student)
        {
            var existingStudent = await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
            if (existingStudent == null)
            {
                return null;
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.BirthsDay = student.BirthsDay;
            existingStudent.SchoolYear = student.SchoolYear;
            existingStudent.SchoolClass = student.SchoolClass;
            existingStudent.EducationLevel = student.EducationLevel;
            existingStudent.IsWoomen = student.IsWoomen;

            await _dbContext.SaveChangesAsync();

            return existingStudent;
        }
    }
}
