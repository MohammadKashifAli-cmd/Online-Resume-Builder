using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineResumeBuilder.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public required string JobTitle { get; set; }
        public string ProfileImage { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State {  get; set; }
        public required int ZipCode { get; set; }
        public EducationInfo EducationInfo { get; set; }
        public Experience Experience { get; set; }
        public ICollection<Skills> KeySkills { get; set; }

    }
}
