using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;


namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {

        // GET -> Root route "/"
        [HttpGet("")]
        public IActionResult Index()
        {
            string Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            return View("Index", Message);
        }

        // GET -> numbers route "/numbers"
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            return View("numbers", Numbers);
        }

        // GET -> users route "/users"
        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> ManyUsers = new List<User>();

            User John = new User("John", "Stevens");
            User LeeAnn = new User("LeeAnn", "Stevens");
            User Caleb = new User("Caleb", "Stevens");
            User Madeleine = new User("Madeleine", "Stevens");
            User Grace = new User("Grace", "Stevens");
            User Ezra = new User("Ezra", "Stevens");
            ManyUsers.Add(John);
            ManyUsers.Add(LeeAnn);
            ManyUsers.Add(Caleb);
            ManyUsers.Add(Madeleine);
            ManyUsers.Add(Grace);
            ManyUsers.Add(Ezra);

            return View("users", ManyUsers);
        }

        // GET -> user route "/user"
        [HttpGet("user")]
        public IActionResult User()
        {
            User John = new User("John","Stevens");
            return View("user", John);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
