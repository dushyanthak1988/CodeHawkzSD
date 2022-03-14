using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Courses
{
    public class CourseEnrollQuery : IRequest<CourseEnrollQueryResult>
    {
        public string CourseID { get; set; }
        public string StudentID { get; set; }
    }

    public class CourseEnrollQueryResult
    {
        public Course CourseInfor { get; set; }
    }

    public class CourseEnrollQueryHandler : IRequestHandler<CourseEnrollQuery, CourseEnrollQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public CourseEnrollQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<CourseEnrollQueryResult> Handle(CourseEnrollQuery request, CancellationToken cancellationToken)
        {
            var Courseobj = dataContext.Courses.Where(row => row.ID.ToString() == request.CourseID.Trim()).Include(std => std.Students).SingleOrDefault();

            var CourseModelobj = mapper.Map<CourseModel>(Courseobj);

            var Studentobj = dataContext.Students.Where(row => row.ID.ToString() == request.StudentID.Trim()).SingleOrDefault();

            if (CourseModelobj.CanEnrollMoreStudents)
            {
                Courseobj.Students.Add(Studentobj);
                dataContext.SaveChanges();

            }

            return new CourseEnrollQueryResult
            {
                CourseInfor = Courseobj
            };
        }
    }
}
