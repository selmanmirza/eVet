using System.ComponentModel.DataAnnotations;

namespace eVet.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage="Ad girmek zorunludur.")]
    public string Ad {get; set;} = string.Empty;        // string.Empty kullanımı da olur ? da olur.

    [Required(ErrorMessage="Soyad girmek zorunludur.")]
    public string? Soyad {get; set;}

    [Required(ErrorMessage="E-posta girmek zorunludur.")]
    [EmailAddress(ErrorMessage="Geçerli bir E-posta adresi giriniz.")]
    public string Email {get; set;} = string.Empty;

    [Required(ErrorMessage="Şifre girmek zorunludur.")]
    [DataType(DataType.Password)]
    public string Password {get; set;} = string.Empty;

    [Required(ErrorMessage = "Şifre tekrarı zorunludur.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
    public string ConfirmPassword {get; set;} = string.Empty;


}