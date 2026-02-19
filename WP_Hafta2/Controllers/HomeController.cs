using Microsoft.AspNetCore.Mvc;
using WP_Hafta2.Models;

namespace WP_Hafta2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            ViewData["Baslik"] = "Kullanıcı Girişi Ekranı";
            ViewData["Baslik_En"] = "Login Screen";

            ViewBag.Input1 = "Email";
            ViewBag.Input2 = "Şifre";

            return View();
        }
        [HttpPost]
        public IActionResult LoginControl(User user)
        {
            if (user.Email=="hikmet.canli@gedik.edu.tr" && user.Password == "1")
            {
                return Ok();
            }
            else
            {
                return NotFound();
            } 
        }

        public IActionResult Index()
        {
            //Veri tabanından kitap bilhgileri al
            //Veri tabanı bağlantısı olmadığı için manuel liste oluştur
            Kitap kitap=new Kitap(); //Kitap Nesnesi oluştur.
            kitap.Id = 1;
            kitap.KitapAdi = "NESNEYE YÖNELİK PROGRAMLAMA";
            kitap.Yazar = "SİNAN TOKLU";
            kitap.Fiyat = 200;
            
            
            return View(kitap);
        }
        public IActionResult KitapKayit()
        {
            return View();
        }

       
    }
}
