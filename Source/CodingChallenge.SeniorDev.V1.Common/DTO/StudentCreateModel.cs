using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.DTO
{
    public class StudentCreateModel
    {
        [RegularExpression(@"^[ST]+\d{0,3}$")]
        [Required]
        public string RegistrationID { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"^([0-9]{9}[x|X|v|V]|[0-9]{12})$")]
        [Required]
        public string NICNo { get; set; }

    }
}
