using System.ComponentModel.DataAnnotations;

namespace eVet.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage ="E-posta girmek zorunludur.")]
    [EmailAddress(ErrorMessage="Geçerli bir e-posta giriniz.")]
    public string Email {get; set;} = string.Empty;

    [Required(ErrorMessage="Şifre girmek zorunludur.")]
    [DataType(DataType.Password)]
    public string Password {get; set;} = string.Empty;

    public bool RememberMe {get; set;}
}