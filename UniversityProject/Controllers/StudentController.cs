using Microsoft.AspNetCore.Mvc;
using UniversityProject.Models;

namespace UniversityProject.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            var student=Data.Students;
            return View(student);
        }
        public IActionResult Detail(int id)
        {
            var student = Data.Students.Find(x => x.Id == id);
            if (student == null)
            {
                return View("Error");
            }
            return View(student);
        }
    }
}
