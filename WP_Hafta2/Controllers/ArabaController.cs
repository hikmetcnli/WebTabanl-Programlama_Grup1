using Microsoft.AspNetCore.Mvc;
using WP_Hafta2.Models;

namespace WP_Hafta2.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            //    Araba a1 = new Araba();
            //    a1.Id = 1;
            //    a1.Color = "Kırmızı";
            //    a1.Model = 2022;
            //    a1.Fiyat = 4444;

            //    Araba a2 = new Araba();
            //    a2.Id = 1;
            //    a2.Color = "Sarı";
            //    a2.Model = 2022;
            //    a2.Fiyat = 4444;

            //    var arabalar = new List<Araba>();
            //    arabalar.Add(a1);
            //    arabalar.Add(a2);


            var arabalar = new List<Araba>
            {
                new Araba {Id = 1,Model="Mercedes",Color="Beyaz",Yil=2020,Fiyat=4500000},
                new Araba {Id = 2, Model="Audi", Color="Siyah", Yil=2018,Fiyat=3000000},
                new Araba {Id = 3, Model="Renault", Color="Kırmızı", Yil=2025,Fiyat=1000000}

            };


            return View(arabalar);
        }
    }
}
