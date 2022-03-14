using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Students
{
    public class CreateStudentQuery : IRequest<CreateStudentQueryResult>
    {
        public StudentCreateModel student { get; set; }
    }
    public class CreateStudentQueryResult
    {
        public Student student { get; set; }
    }
    class CreateStudentQueryHandler : IRequestHandler<CreateStudentQuery, CreateStudentQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public CreateStudentQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<CreateStudentQueryResult> Handle(CreateStudentQuery request, CancellationToken cancellationToken)
        {
            var studentObj = mapper.Map<Student>(request.student);
            studentObj.ID = Guid.NewGuid();
            dataContext.Students.Add(studentObj);
            dataContext.SaveChanges();


            return new CreateStudentQueryResult { student = studentObj };


        }
    }
}
