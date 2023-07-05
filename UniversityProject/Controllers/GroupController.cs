using Microsoft.AspNetCore.Mvc;
using UniversityProject.Models;

namespace UniversityProject.Controllers
{
    public class GroupController : Controller
    {
        private List<Groups> _groups;
        public GroupController()
        {
            _groups = new List<Groups> { new Groups { Id = 1, Name = "p110" }, new Groups { Id = 2, Name = "p112" }, new Groups { Id = 3, Name = "p115" } };
        }
        public IActionResult Index()
        {
            return View(_groups);
        }
    }
}
