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
    internal class STtuCrsResConfiguration : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Property(sc => sc.StudentId).IsRequired(true);
            builder.Property(sc => sc.CourseId).IsRequired(true);
            builder.Property(sc=>sc.grade).IsRequired(false);
        }
    }
}
