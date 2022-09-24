using Microsoft.AspNetCore.Mvc;
using ViewHelpers.Models;

namespace ViewHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // Url'den çağrılacak
        public IActionResult Kaydet()
        {
            return View();
        }

        [HttpPost] // form'dan çağrılacak...
        public IActionResult Save(Kullanici model)
        {

            return View();
        }
        // Default her zaman HTTPGET'tir
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kullanici model)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Kullanici model)
        {

            return View();
        }
    }
}