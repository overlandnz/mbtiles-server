using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MBTilesServer.Models;

namespace MBTilesServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MapboxToken = ConfigurationManager.Read("Tiles:MapboxKey");
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
    }
}