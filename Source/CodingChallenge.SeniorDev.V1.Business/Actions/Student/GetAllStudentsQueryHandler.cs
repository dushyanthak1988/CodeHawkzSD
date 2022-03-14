using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Student
{
    public class GetAllStudentsQuery : IRequest<GetAllStudentsQueryResult>
    {

    }
    public class GetAllStudentsQueryResult
    {
        public List<StudentModel> StudentList { get; set; }
    }
    class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, GetAllStudentsQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllStudentsQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<GetAllStudentsQueryResult> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await dataContext.GetAllStudents();

            return new GetAllStudentsQueryResult
            {
                StudentList = mapper.Map<List<StudentModel>>(students)
            };
        }
    }
}
