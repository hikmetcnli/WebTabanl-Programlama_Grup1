using Microsoft.AspNetCore.Mvc;

namespace WP_Hafta2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KitapKayit()
        {
            return View();
        }

       
    }
}
