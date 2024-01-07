using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Core.Models
{
    public class StudentEnrollment
    {
        public int Id { get; set; }
        public int StudentId  { get; set; }
        
        public string CollegeName { get; set; } = null!;
        public DateTime EnrollmentStartDate { get; set; }
        public DateTime EnrollmentEndDate { get; set; }
        public virtual StudentGrade StudentGrade { get; set; } = null!;
    }
}
