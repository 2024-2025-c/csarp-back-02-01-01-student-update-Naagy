using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "János",
                    LastName = "Jegy",
                    BirthsDay = new DateTime(2011, 10, 10),
                    SchoolYear = 9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel = "érettségi"
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Szonja",
                    LastName = "Stréber",
                    BirthsDay = new DateTime(2012, 4, 4),
                    SchoolYear = 10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel = "érettségi"
                }
            };

            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Feleltető",
                    LastName = "Ferenc",
                    BirthsDay = new DateTime(2001, 8, 1),
                    IsWoomen = false,
                    IsHeadTeacher = false
                },
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Aranyos",
                    LastName = "Aranka",
                    BirthsDay = new DateTime(2002, 2, 24),
                    IsWoomen = true,
                    IsHeadTeacher = true
                }
            };

            modelBuilder.Entity<Teacher>().HasData(teachers);

            List<Parent> parents = new List<Parent>
            {
                new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ferenc",
                    LastName = "Kiss",
                    BirthsDay = new DateTime(2001, 8, 1),
                    IsFather = true
                },
                new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ágnes",
                    LastName = "Molnár",
                    BirthsDay = new DateTime(2002, 2, 24),
                    IsFather = false
                }
            };

            modelBuilder.Entity<Parent>().HasData(parents);

            List<Club> clubs = new List<Club>
            {
                new Club
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Madrid",
                    LastName = "Real",
                    BirthsDay = new DateTime(1902, 3, 6)
                },
                new Club
                {
                    Id = Guid.NewGuid(),
                    FirstName = "United",
                    LastName = "Macnhester",
                    BirthsDay = new DateTime(1878, 2, 24)
                }
            };

            modelBuilder.Entity<Club>().HasData(clubs);
        }
    }
}
