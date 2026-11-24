using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet adı zorunludur.")]
        [StringLength(100)]
        public string Ad { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Aciklama { get; set; } // bos birakilabilir 

        [Required]
        [Range(5, 480, ErrorMessage = "Süre 5 ile 480 dakika arasında olmalıdır.")]
        public int SureDakika { get; set; }

        [Required]
        [Range(0, 100000, ErrorMessage = "Geçerli bir ücret giriniz.")]
        public float Ucret { get; set; } 
    }
}