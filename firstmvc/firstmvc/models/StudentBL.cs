using firstmvc.data.Dbcontext;

namespace firstmvc.models
{
    public class StudentBL
    {
        StudemtDbContextcs Context = new StudemtDbContextcs();
        public List<Student> GetAllStudents()
        {
            return Context.students.ToList();
        }
        public Student GetStudentById(int id)
        {
            return Context.students.FirstOrDefault(s => s.id == id);
        }
    }
}
