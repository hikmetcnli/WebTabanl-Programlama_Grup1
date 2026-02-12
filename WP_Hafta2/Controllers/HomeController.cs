using Microsoft.AspNetCore.Mvc;

namespace WP_Hafta2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Merhaba Dünya !";
        }
        public int Topla()
        {
            int aa = 10;
            int bb = 20;

            return aa + bb; 
        }
    }
}
