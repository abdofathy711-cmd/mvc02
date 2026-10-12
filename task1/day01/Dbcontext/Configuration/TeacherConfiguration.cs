using day01.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.Dbcontext.Configuration
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Teachers> builder)
        {
            //teacher configuration
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name)
                .IsRequired(true)
                .HasMaxLength(100);
            builder.Property(t => t.Salary)
                .IsRequired(true)
                .HasPrecision(18, 2);
            builder.Property(t => t.DepartmentId)
                .IsRequired(false);
            builder.Property(t => t.CourseID)
                .IsRequired(false);
            builder.Property(t => t.Address)
                .IsRequired(false)
                .HasMaxLength(200);
            // Configure the relationships with course
            builder.HasOne(t => t.course)
                .WithMany(c => c.teachers)
                .HasForeignKey(t => t.CourseID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
