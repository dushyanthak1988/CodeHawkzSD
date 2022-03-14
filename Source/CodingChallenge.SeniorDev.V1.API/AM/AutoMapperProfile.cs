using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;

namespace CodingChallenge.SeniorDev.V1.API.AM
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Course, CourseModel>()
                .ForMember(c => c.TeacherFullName, o => o.MapFrom(c => $"{c.Teacher.FirstName} {c.Teacher.LastName}"))
                .ForMember(c => c.CurrentStudentCount, o => o.MapFrom(c => c.Students.Count))
                .ForMember(c => c.CanEnrollMoreStudents, o => o.Ignore());

            CreateMap<Student, StudentModel>()
               .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"));

            CreateMap<Teacher, TeacherModel>()
              .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"));

            CreateMap<StudentCreateModel ,Student>();
        }
    }
}
