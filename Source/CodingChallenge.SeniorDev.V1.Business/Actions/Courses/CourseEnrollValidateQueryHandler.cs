using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Courses
{
    public class CourseEnrollValidateQuery : IRequest<CourseEnrollValidateQueryResult >
    {
        public string CourseID { get; set; }
        public string  StudentID { get; set; }


    }

    public class CourseEnrollValidateQueryResult
    {
        public string Errormsg { get; set; }
    }

    public class CourseEnrollValidateQueryHandler : IRequestHandler<CourseEnrollValidateQuery, CourseEnrollValidateQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public CourseEnrollValidateQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<CourseEnrollValidateQueryResult> Handle(CourseEnrollValidateQuery request, CancellationToken cancellationToken)
        {

           var data   = dataContext.Courses.Where(row => row.ID.ToString() == request.CourseID.Trim() && row.Students.Where( std => std.ID.ToString() == request.StudentID.Trim() && !std.IsDeleted ).Count()> 0  ).ToList();

            string Errormsg = data.Count > 0 ? "Already Enrolled" : "";

            return new CourseEnrollValidateQueryResult
            {
                Errormsg = Errormsg
            };


        }
    }


}
