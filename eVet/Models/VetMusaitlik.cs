using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class VetMusaitlik
    {
        public int Id { get; set; }

        [Required]
        public int VeterinerId { get; set; }
        public Veteriner? Veteriner { get; set; }

        [Required]
        public DayOfWeek Gun { get; set; }  // haftanin günleri. 

        [Required]
        public TimeOnly BaslangicSaati { get; set; }    // belli saat araliginda müsaitlik arayacağımız icin DateTime yerine kullandik.

        [Required]
        public TimeOnly BitisSaati { get; set; }
    }
}