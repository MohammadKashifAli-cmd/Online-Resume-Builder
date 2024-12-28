using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineResumeBuilder.Models
{
    public class EducationInfo
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLocation { get; set; }
        public DateOnly StartMonth { get; set; }
        public DateOnly EndMonth { get; set; }
        public DateOnly StartYear { get; set; }
        public DateOnly EndYear { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
