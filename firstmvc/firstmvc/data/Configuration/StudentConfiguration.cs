using firstmvc.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace firstmvc.data.Configuration

{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(s => s.id);
            builder.Property(s => s.name)
                .IsRequired(true)
                .HasMaxLength(100);
            builder.Property(s => s.age)
                .IsRequired(false);
        }
    }
}
