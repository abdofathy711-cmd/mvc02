using day01.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.Dbcontext.Configuration
{
    internal class studentConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            //student configuration
            builder.HasKey(s => s.Id);
            builder.Property(s => s.age)
                .IsRequired(false);
            builder.Property(s => s.Name)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(s => s.DepartmentId)
                .IsRequired(false); 
            // Configure the relationships with stucrsres
            builder.HasMany(s => s.StuCrsRes)
                .WithOne(scr => scr.student)
                .HasForeignKey(scr => scr.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
