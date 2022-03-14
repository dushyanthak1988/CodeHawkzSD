﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.DTO
{
    public class TeacherModel
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
