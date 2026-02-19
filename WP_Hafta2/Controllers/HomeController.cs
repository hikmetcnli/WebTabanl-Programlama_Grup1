using Microsoft.AspNetCore.Mvc;
using WP_Hafta2.Models;

namespace WP_Hafta2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginControl(User user)
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
