using System.ComponentModel.DataAnnotations;

namespace OnlineShop.PL.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Почта не заполнена")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не задан")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
