using Microsoft.AspNetCore.Mvc;
using WP_Hafta2.Models;

namespace WP_Hafta2.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            var OgrenciListesi = 
            new List<Ogrenci> { 
            new Ogrenci{No=1,Adi="Hikmet",Soyadi="CANLI",TC="-",Email="hikmet@hotmail.com",Bolum="Yapay Zeka"},
            new Ogrenci{No=2,Adi="Sinan",Soyadi="TOKLU",TC="-",Email="sinan@hotmail.com",Bolum="Yapay Zeka"},
            new Ogrenci{No=3,Adi="Muhamet",Soyadi="Başaslan",TC="-",Email="hikmet@hotmail.com",Bolum="Yapay Zeka"},
            new Ogrenci{No=4,Adi="Fatih",Soyadi="Bal",TC="-",Email="hikmet@hotmail.com",Bolum="Yapay Zeka"},
            new Ogrenci{No=5,Adi="Ali",Soyadi="Al",TC="-",Email="hikmet@hotmail.com",Bolum="Yapay Zeka"},
                };

            return View(OgrenciListesi);
        }
    }
}
