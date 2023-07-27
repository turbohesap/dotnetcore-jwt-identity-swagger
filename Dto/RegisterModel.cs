using System.ComponentModel.DataAnnotations;

namespace IdentityJwtApi.Dto;

public class RegisterModel
{
    [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Email boş geçilemez")]
    [EmailAddress(ErrorMessage = "Email formatı uygun değil")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Şifre boş geçilemez")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Şifre tekrarı boş geçilemez")]
    [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
    public string? ConfirmPassword { get; set; }
}