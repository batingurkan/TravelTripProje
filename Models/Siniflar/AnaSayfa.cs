using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; } 
        public string Baslik { get; set; }

        public string Aciklama { get; set; }
    }
}
