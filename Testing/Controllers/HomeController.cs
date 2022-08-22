using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testing.Models;
using Testing.Models.Interfaces;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository empRepo;

        //jb hum code run kre ge to controller ke andr 1 object inject hoga
        public HomeController(ILogger<HomeController> logger,IEmployeeRepository emp)
        {
            _logger = logger;
            empRepo = emp;
        }


        public IActionResult Index()
        {
            return View(empRepo.GetALlEmployee());
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