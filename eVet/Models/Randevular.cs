using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public enum RandevuDurumu
    {
        Bekliyor = 0,
        Onaylandi = 1,
        Reddedildi = 2,
        Tamamlandi = 3
    }

    public class Randevular
    {
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; }
        public Pet? Pet { get; set; }

        [Required]
        public int VeterinerId { get; set; }
        public Veteriner? Veteriner { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public Service? Service { get; set; }

        [Required]
        public DateOnly Tarih { get; set; }

        [Required]
        public TimeOnly BaslangicSaati { get; set; }

        [Required]
        public TimeOnly BitisSaati { get; set; }

        [Required]
        public float Ucret { get; set; }

        public RandevuDurumu Durum { get; set; } = RandevuDurumu.Bekliyor;

        [StringLength(1000)]
        public string? MuayeneNotu { get; set; }    // muayene ilk alındıgında boş olacak o yüzden ? koyduk.
    }
}