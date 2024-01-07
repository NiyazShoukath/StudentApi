using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Core.Infrastructure.Configurations
{
    public class StudentEnrollmentConfiguration : IEntityTypeConfiguration<StudentEnrollment>
    {
        public void Configure(EntityTypeBuilder<StudentEnrollment> builder)
        {
            builder.ToTable("StudentEnrollment");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.EnrollmentStartDate).IsRequired();
            builder.Property(e => e.EnrollmentEndDate).IsRequired();
            builder.HasOne(x => x.StudentGrade).WithOne();
         

        }
    }
}
