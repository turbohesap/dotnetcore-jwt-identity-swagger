using System.ComponentModel.DataAnnotations;

namespace IdentityJwtApi.Dto;

public class LoginModel
{
    [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Şifre boş geçilemez")]
    public string? Password { get; set; }
}