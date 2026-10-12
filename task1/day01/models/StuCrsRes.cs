using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.models
{
    internal class StuCrsRes
    {
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? grade { get; set; }
        public Students student { get; set; }
        public Courses course { get; set; }
    }
}
