using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Core.Models
{
    public class StudentGrade
    {
        public int Id { get; set; }
        public int StudentEnrollmentId  { get; set; }
        public string Grade { get; set; } = null!;
    }
}
