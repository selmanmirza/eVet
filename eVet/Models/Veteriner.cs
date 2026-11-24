using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class Veteriner
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty; // aspcore identity idleri string olarak tutar. veritabanindaki foreign key.
        public ApplicationUser? User { get; set; }

        [Required(ErrorMessage = "Uzmanlık alanı zorunludur.")]
        [StringLength(150)]
        public string UzmanlikAlani { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Biyografi { get; set; }
    }
}