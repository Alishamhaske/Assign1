using Assign1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    public class User1Controller : Controller
    {
      

        [HttpGet]
        public IActionResult AddUser1()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddUser1(User1  user1)
        {
            return View();

        }
    }
}
