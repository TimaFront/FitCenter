using FitCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitCenter.Controllers
{
    public class HomeController : Controller
    {

        private FitCenterContext db;

        public HomeController(FitCenterContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var treners = db.Treners.ToList();
            return View(treners);
        }

        //[HttpGet]
        //public IActionResult Karti()
        //{
        //    var clients = db.Clients.ToList();
        //    return View(clients);
        //}

        public IActionResult Vakansii()
        {
            return View();
        }

        public IActionResult Bas()
        {
            return View();
        }

        public IActionResult Coach(int id)
        {
            var trener = db.Treners.First(x => x.Id == id);
            return View("Coach", trener); /*просто тренера передал*/
        }

        [HttpGet]
        public IActionResult Karti()
        {
            var clients = db.Clients.ToList();
            return View(clients);
        }

        [HttpPost]
        public string Karti(Client client)
        {
            var clients = db.Clients.ToList();
            db.Clients.Add(client);
            db.SaveChanges();

            return "Вы успешно купили абонемент";
        }

        public IActionResult Kont()
        {
            return View();
        }

        public IActionResult Krio()
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
    }
}