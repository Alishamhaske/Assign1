using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assign1.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult CourseDetails()
        {
            List<string> cou = new List<string>()
            {
                "Yes","NO"
            };
            ViewData["cou"] = new SelectList(cou);
            return View();
        }
        [HttpPost]
        public IActionResult CourseDetails(IFormCollection form, ICollection<string> skill)
        {

            ViewBag.Name = form["name"];
            ViewBag.Gender = form["gender"];

            ViewBag.Skill = form["skill"];
            ViewBag.Cou = form["cou"];

            return View("Displaydetails");
        }
    }
}
