using System.ComponentModel.DataAnnotations;
namespace OnlineShop.PL.ViewModel
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Почта не заполнена")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не заполнен")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Имя не заполнено")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилия не заполнена")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Имя пользователя не заполнено")]
        public string UserName { get; set; }
    }
}
