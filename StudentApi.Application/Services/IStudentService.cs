using StudentApi.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Application.Services
{
    public interface IStudentService
    {   CommonResponse GetStudents();
        CommonResponse GetStudentsInfo(int Id);
       
        CommonResponse GetEntrollment(int Id);
        CommonResponse GetGrade(int Id);
    }
}
