using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public virtual StudentEnrollment StudentEnrollment { get; set; }


    }
}
