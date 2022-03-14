using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Students
{
    public class ValidateStudentQuery : IRequest<ValidateStudentQueryResult>
    {
        public ValidateType SearchType { get; set; }
        public StudentCreateModel student { get; set; }
    }
    public class ValidateStudentQueryResult
    {
        public string Errormsg { get; set; }
    }
    class ValidateStudentQueryHandler : IRequestHandler<ValidateStudentQuery, ValidateStudentQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public ValidateStudentQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }


        public async Task<ValidateStudentQueryResult> Handle(ValidateStudentQuery request, CancellationToken cancellationToken)
        {
            string Errormsg = "";


            if (request.SearchType == ValidateType.SearchByNIC)
            {
                var obj = dataContext.Students.Where(row => string.Equals(row.NICNo.Trim(), request.student.NICNo.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (obj.Count > 0)
                {
                    Errormsg = "AllReady added Same NIC No";

                }
            }
            else if (request.SearchType == ValidateType.SearchByEmail)
            {
                var obj = dataContext.Students.Where(row => string.Equals(row.Email.Trim(), request.student.Email.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (obj.Count > 0)
                {
                    Errormsg = "AllReady added Same Email Address";

                }
            }
            else if (request.SearchType == ValidateType.RegistrationID)
            {
                var obj = dataContext.Students.Where(row => string.Equals(row.RegistrationID.Trim(), request.student.RegistrationID.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (obj.Count > 0)
                {
                    Errormsg = "AllReady added Same Registration ID";

                }
            }

            return new ValidateStudentQueryResult
            {

                Errormsg = Errormsg
            };
        }
    }

    public enum ValidateType
    {
        SearchByEmail,
        SearchByNIC,
        RegistrationID

    }

}
