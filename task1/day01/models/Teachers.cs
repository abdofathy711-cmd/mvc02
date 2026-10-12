using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.models
{
    internal class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public String Address { get; set; }
        public int? CourseID { get; set; }
        public int? DepartmentId { get; set; }
        public Departments department { get; set; }
        public Courses course { get; set; }

    }
}
