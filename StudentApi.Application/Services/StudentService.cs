using Microsoft.EntityFrameworkCore;
using StudentApi.Core.Infrastructure;
using StudentApi.Core.Models;
using StudentApi.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentContext _StudentDbContext;
        public StudentService(StudentContext StudentDbContext)
        {
            _StudentDbContext = StudentDbContext;
        }
        public CommonResponse GetStudents()
        {
            try
            {
                
                var stList = _StudentDbContext.Students
                    .Select(x => new { x.Id, x.FirstName, x.Lastname, x.DateOfBirth })
                    .ToList();
                if( stList.Count > 0 ) 
                     return CommonResponse.Ok(stList);
                else
                    return CommonResponse.NotFound("Data not found");
            }
            catch (Exception ex)
            {
                return CommonResponse.Error(ex);
            }
        }
        public CommonResponse GetEntrollment(int Id)
        {
            try
            {
                var EnrollementData = _StudentDbContext.StudentEnrollments.Where(x => x.StudentId == Id).FirstOrDefault();
                if (EnrollementData == null) return CommonResponse.NotFound("Data not found");

                return CommonResponse.Ok(EnrollementData);
            }catch (Exception ex)
            {
                return CommonResponse.Error(ex);
            }
        }

        public CommonResponse GetGrade(int Id)
        {
            try
            {
                var GradeData = _StudentDbContext.StudentGrades.Where(x => x.StudentEnrollmentId == Id).FirstOrDefault();
                if (GradeData == null) return CommonResponse.NotFound("Data not found");

                return CommonResponse.Ok(GradeData);
            }
            catch (Exception ex)
            {
                return CommonResponse.Error(ex);
            }
        }

        public CommonResponse GetStudentsInfo(int Id)
        {
            try
            {
                var StudentDetail = _StudentDbContext.Students
                                                 .Include(x=>x.StudentEnrollment)
                                                 .ThenInclude(x=>x.StudentGrade)
                                                 .Where(x => x.Id == Id).FirstOrDefault();
                if (StudentDetail == null) return CommonResponse.NotFound("Data not found");

                return CommonResponse.Ok(StudentDetail);
            }
            catch (Exception ex)
            {
                return CommonResponse.Error(ex);
            }
        }
    }
}
