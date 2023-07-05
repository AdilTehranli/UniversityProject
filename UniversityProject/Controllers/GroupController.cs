using Microsoft.AspNetCore.Mvc;
using UniversityProject.Models;

namespace UniversityProject.Controllers
{
    public class GroupController : Controller
    {

        public IActionResult Index()
        {
            var groups=Data.Groups;
            return View(groups);
        }
    }
}
