using Microsoft.AspNetCore.Mvc;
using UniversityProject.Models;

namespace UniversityProject.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> _students;
        public StudentController()
        {
            _students = new List<Student>
            {
                new Student{Id=1,Name="Kamil",Surname="Zeynalli",Group="p110"},
                new Student{Id=2,Name="Agakisi",Surname="Neymetulla",Group="p112"},
                new Student{Id=3,Name="Nigar",Surname="Memmedli",Group="p115"},
                new Student{Id=4,Name="Rovsen",Surname="Eliyev",Group="p118"}
            };
        }
        public IActionResult Index()
        {
            return View(_students);
        }
        public IActionResult Detail(int id)
        {
            var student = _students.Find(x => x.Id == id);
            return View(student);
        }
    }
}
