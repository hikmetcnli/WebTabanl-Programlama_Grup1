using System.ComponentModel.DataAnnotations;

namespace WP_Hafta2.Models
{
    public class Araba
    {
        public int Id { get; set; }
        public string Model {  get; set; }
        public string Color { get; set; }
        public double Fiyat { get; set; }

        [Range(2020,2030)]
        public int Yil { get; set; }
    }
}
