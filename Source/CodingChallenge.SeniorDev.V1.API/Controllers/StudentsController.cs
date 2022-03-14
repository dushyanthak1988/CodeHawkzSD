﻿using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Business.Actions.Students;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class StudentsController : BaseController
    {
        public StudentsController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration)
            : base(mediator, configuration)
        { }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<StudentModel>>> GetAll()
        {
            var result = await mediator.Send(new GetAllStudentsQuery());
            return Ok(result.StudentList);
        }

        [HttpPost]
        public async Task<ActionResult<StudentModel>> Create(StudentCreateModel request)
        {
            var result = await mediator.Send(new CreateStudentQuery { student = request });
            return Ok(result.student);
        }

        [HttpPut]
        public async Task<ActionResult<List<string>>> Delete(StudentDeleteModel request)
        {
            var result = await mediator.Send(new DeleteStudentQuery { IDList = request.IDList });
            return Ok(result.DeletedID);
        }
    }
}
