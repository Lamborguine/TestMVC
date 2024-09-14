using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TesteMVC.Models;

namespace TesteMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Lucas";
            home.Email = "Lucas@gmail.com";
            home.NumCel = "8199930408";

            return View(home);
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
