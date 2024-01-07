using Microsoft.EntityFrameworkCore;
using StudentApi.Core.Infrastructure.Configurations;
using StudentApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Core.Infrastructure
{
    public partial class StudentContext : DbContext
    {

        public StudentContext()
        {
            
        }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   => optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PADQNA6;Integrated Security=True;TrustServerCertificate=true;Initial Catalog=Student;User ID=sa;Password=Datum123!");
   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        // => optionsBuilder.UseSqlServer();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new StudentConfiguration());
            mb.ApplyConfiguration(new StudentEnrollmentConfiguration());
            mb.ApplyConfiguration(new StudentGradeConfiguration());
        }
    }
}
