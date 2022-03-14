using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.DataAccess.EF
{
    public class CodingChallengeDataContext : DbContext
    {
        public CodingChallengeDataContext(DbContextOptions options) : base(options)
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        public Task<List<Course>> GetAllCourses()
            => Courses.Where(c => !c.IsDeleted)
                      .Include(stud => stud.Students)
                      .Include(Teach => Teach.Teacher)
                      .OrderBy(c => c.Title)
                       .AsNoTracking().ToListAsync();
        public Task<List<Student>> GetAllStudents()
          => Students.Where(c => !c.IsDeleted).OrderBy(c => c.FirstName).AsNoTracking().ToListAsync();
        public Task<List<Teacher>> GetAllTeacher()
           => Teachers.Where(c => !c.IsDeleted).OrderBy(c => c.FirstName).AsNoTracking().ToListAsync();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();

            var T1 = new Teacher
            {
                Birthdate = DateTime.Parse("1955-12-26"),
                Email = "Teacher1@gmail.com",
                FirstName = "Teacher",
                LastName = "1",
                ID = guid1

            };
            var T2 = new Teacher
            {
                Birthdate = DateTime.Parse("1955-11-26"),
                Email = "Teacher2@gmail.com",
                FirstName = "Teacher",
                LastName = "2",
                ID = guid2

            };
            modelBuilder.Entity<Teacher>().HasData(T1, T2);

            var S1 = new Student
            {
                Birthdate = DateTime.Parse("1988-10-23"),
                Email = "Student1@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "1",
                NICNo = "882970051V",
                RegistrationID = "ST001"
            };

            var S2 = new Student
            {
                Birthdate = DateTime.Parse("1985-10-23"),
                Email = "Student2@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "2",
                NICNo = "852970051V",
                RegistrationID = "ST002"
            };


            var S3 = new Student
            {
                Birthdate = DateTime.Parse("1983-10-23"),
                Email = "Student3@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "3",
                NICNo = "832970051V",
                RegistrationID = "ST003"
            };


            var S4 = new Student
            {
                Birthdate = DateTime.Parse("1984-10-23"),
                Email = "Student4@gmail.com",
                FirstName = "Studen4",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "4",
                NICNo = "842970051V",
                RegistrationID = "ST004"
            };

            var S5 = new Student
            {
                Birthdate = DateTime.Parse("1981-10-23"),
                Email = "Student5@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "5",
                NICNo = "812970051V",
                RegistrationID = "ST005"
            };
            var S6 = new Student
            {
                Birthdate = DateTime.Parse("1982-10-23"),
                Email = "Student6@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "6",
                NICNo = "822970051V",
                RegistrationID = "ST001"
            };


            var S7 = new Student
            {
                Birthdate = DateTime.Parse("1980-10-23"),
                Email = "Student7@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "7",
                NICNo = "802970051V",
                RegistrationID = "ST007"
            };


            var S8 = new Student
            {
                Birthdate = DateTime.Parse("1986-10-23"),
                Email = "Student8@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "8",
                NICNo = "862970051V",
                RegistrationID = "ST008"
            };

            var S9 = new Student
            {
                Birthdate = DateTime.Parse("1989-10-23"),
                Email = "Student9@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "9",
                NICNo = "892970051V",
                RegistrationID = "ST009"
            };

            var S10 = new Student
            {
                Birthdate = DateTime.Parse("1987-10-23"),
                Email = "Student10@gmail.com",
                FirstName = "Student",
                ID = Guid.NewGuid(),
                IsDeleted = false,
                LastName = "10",
                NICNo = "872970051V",
                RegistrationID = "ST010"
            };

            modelBuilder.Entity<Student>().HasData(S1, S2, S3, S4, S5, S6, S7, S8, S9, S10);

            var C1 = new Course
            {
                ID = Guid.NewGuid(),
                Description = "Course 1 ",
                Subject = "Subject 1",
                IsDeleted = false,
                MaximumStudentLimit = 20,
                TeacherID = guid1,
                Title = "Course 1 "
            };
            var C2 = new Course
            {
                ID = Guid.NewGuid(),
                Subject = "Subject 2",
                Description = "Course 2 ",
                IsDeleted = false,
                MaximumStudentLimit = 30,
                Title = "Course 2 ",
                TeacherID = guid2
            };
            modelBuilder.Entity<Course>().HasData(C1, C2);

        }
    }
}
