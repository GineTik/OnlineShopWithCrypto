using System.ComponentModel.DataAnnotations;

namespace OnlineShop.PL.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Почта не заполнена")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Введите коректную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не задан")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Пароль слишком большой (максимум 50 символов)")]
        public string Password { get; set; }
    }
}
