using firstmvc.data.Configuration;
using firstmvc.models;
using Microsoft.EntityFrameworkCore;

namespace firstmvc.data.Dbcontext
{
    public class StudemtDbContextcs : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Student;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
        public DbSet<Student> students { get; set; }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}