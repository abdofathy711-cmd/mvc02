using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01.models
{
    internal class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MgrName { get; set; }
        public List<Teachers> teachers { get; set; }
        public List<Students> students  { get; set; }
        public List<Courses> Courses { get; set; }
    }
}
