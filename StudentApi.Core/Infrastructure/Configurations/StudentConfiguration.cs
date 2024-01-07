using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentApi.Core.Models;

namespace StudentApi.Core.Infrastructure.Configurations
{
    public class StudentConfiguration:IEntityTypeConfiguration<Student>
    {
        
            public void Configure(EntityTypeBuilder<Student> builder)
            { 
                builder.ToTable("Student");
                builder.HasKey(e => e.Id);
                builder.Property(e => e.FirstName).IsRequired();
                builder.Property(e => e.Lastname).IsRequired();
                builder.Property(e => e.DateOfBirth).IsRequired();
            builder.HasOne(x => x.StudentEnrollment).WithOne();
        }
    }
}
