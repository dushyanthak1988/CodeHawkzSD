using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Students
{
    public class DeleteStudentQuery : IRequest<DeleteStudentQueryResult>
    {
        public List<string> IDList { get; set; }
    }
    public class DeleteStudentQueryResult
    {
        public List<string> DeletedID { get; set; }
    }
    class DeleteStudentQueryHandler : IRequestHandler<DeleteStudentQuery, DeleteStudentQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;

        public DeleteStudentQueryHandler(CodingChallengeDataContext dataContext)
        {
            this.dataContext = dataContext;

        }

        public async Task<DeleteStudentQueryResult> Handle(DeleteStudentQuery request, CancellationToken cancellationToken)
        {
            DeleteStudentQueryResult result = new DeleteStudentQueryResult();
            result.DeletedID = new List<string>();

            foreach (var item in request.IDList)
            {
                var studentObj = dataContext.Students.Where(row => row.RegistrationID == item).SingleOrDefault();
                if (studentObj != null)
                {
                    if (!studentObj.IsDeleted)
                    {
                        studentObj.IsDeleted = true;
                        result.DeletedID.Add(item + "Successfully Updated...!!!");
                        dataContext.Students.Update(studentObj);
                        dataContext.SaveChanges();
                    }
                    else
                    {
                        result.DeletedID.Add(item + "is already deleted..!!");
                    }
                }
                else
                {
                    result.DeletedID.Add(item + "is not Found...!!");
                }
            }


            return result;



        }
    }
}
