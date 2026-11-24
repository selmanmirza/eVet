using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class AsiKayitlari
    {
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; }
        public Pet? Pet { get; set; }

        [Required(ErrorMessage = "Aşı adı zorunludur.")]
        [StringLength(100)]
        public string AsiAdi { get; set; } = string.Empty;

        [Required]
        public DateOnly YapildigiTarih { get; set; }

        public DateOnly? SonrakiDozTarihi { get; set; } // bazı aşılar tek doz o yüzden ? koyulur bence.
    }
}