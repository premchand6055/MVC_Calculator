using Microsoft.AspNetCore.Mvc;
using MVC_Calculator.Models;
using System.Diagnostics;

namespace MVC_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult addition()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add()
        {
            int number1 = Convert.ToInt32(HttpContext.Request.Form["txtfirstnum"].ToString());
            int number2 = Convert.ToInt32(HttpContext.Request.Form["txtsecondnum"].ToString());
            int res = number1 + number2;
            ViewBag.Result = res.ToString();
            return View("addition");
        }
    }
}
