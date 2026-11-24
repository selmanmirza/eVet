using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eVet.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(50)]
        public string Ad { get; set; } = string.Empty;

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [StringLength(50)]
        public string Soyad { get; set; } = string.Empty;
    }
}