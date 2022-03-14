using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Teacher
{
    public class GetAllTeachersQuery : IRequest<GetAllTeachersQueryResult>
    {

    }
    public class GetAllTeachersQueryResult
    {
        public List<TeacherModel> TeacherList { get; set; }
    }
    class GetAllTeachersQueryHandler : IRequestHandler<GetAllTeachersQuery, GetAllTeachersQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllTeachersQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        public async Task<GetAllTeachersQueryResult> Handle(GetAllTeachersQuery request, CancellationToken cancellationToken)
        {
            var teacher = await dataContext.GetAllTeacher();

            return new GetAllTeachersQueryResult
            {
                TeacherList = mapper.Map<List<TeacherModel>>(teacher)
            };
        }
    }
}
