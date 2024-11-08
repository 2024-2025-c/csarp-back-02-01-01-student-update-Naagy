﻿using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Student
    {
        public Student(Guid id, string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWoomen)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
            IsWoomen = isWoomen;
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWoomen)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
            IsWoomen = isWoomen;
        }

        public Student()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = DateTime.MinValue;
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
            IsWoomen = false;
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthsDay { get; set; }

        public int SchoolYear { get; set; }

        public SchoolClassType SchoolClass { get; set; }

        public string EducationLevel { get; set; }

        public bool IsWoomen { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({SchoolYear}.{SchoolClass}), Szül: {BirthsDay:yyyy.MM.dd}, Tanulmányi szint: {EducationLevel}";
        }
    }
}
