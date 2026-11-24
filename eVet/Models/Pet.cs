using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; } = string.Empty;
        public ApplicationUser? Owner { get; set; }

        [Required(ErrorMessage = "Evcil hayvan adı zorunludur.")]
        [StringLength(50)]
        public string Ad { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tür zorunludur.")]
        [StringLength(50)]
        public string Tur { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Irk { get; set; }        // boş birakilabilir

        [Required]
        public DateOnly DogumTarihi { get; set; }       // burada belirli bir tarih var.

        [Range(0.1, 200, ErrorMessage = "Geçerli bir kilo giriniz.")]
        public double Kilo { get; set; }

        public string? FotografYolu { get; set; }       // boş birakilabilir.
    }
}