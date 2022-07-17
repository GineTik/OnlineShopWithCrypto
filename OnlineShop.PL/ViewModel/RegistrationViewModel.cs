using System.ComponentModel.DataAnnotations;
namespace OnlineShop.PL.ViewModel
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Почта не заполнена")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Введите коректную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не заполнен")]
        [MinLength(5, ErrorMessage = "Пароль должен содержать не менее 5 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Имя не заполнено")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилия не заполнена")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Имя пользователя не заполнено")]
        [MinLength(5, ErrorMessage = "Имя пользователя должно содержать не менее 5 символов")]
        public string UserName { get; set; }
    }
}
