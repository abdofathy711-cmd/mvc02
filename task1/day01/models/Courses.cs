using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.models
{
    internal class Courses
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Degree   { get; set; }
        public int? MiniDegree { get; set; }
        public int? DepartmentId { get; set; }
        public Departments department { get; set; }
        public List<StuCrsRes> StuCrsRes { get; set; }
        public List<Teachers> teachers { get; set; }

    }
}
