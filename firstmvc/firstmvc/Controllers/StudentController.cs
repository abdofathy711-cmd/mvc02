using firstmvc.models;
using Microsoft.AspNetCore.Mvc;

namespace firstmvc.Controllers
{
    public class StudentController : Controller
    {

      
        public string Index()
        {
            return "Hello from Student Controller";
        }
        // /Student/DetailbyID
        public IActionResult DetailbyID(int id)
        {
            StudentBL sbl = new StudentBL();
            Student? s = sbl.GetStudentById(id);

            return View("showbyID", s);
        }
        // /Student/AllDetails
        public IActionResult alldetails()
        {
            StudentBL sbl = new StudentBL();
            List<Student> students = sbl.GetAllStudents();
            return View("showall", students);
        }
    }
}
