using Microsoft.AspNetCore.Mvc;
using OnlineShop.BLL.Factories;
using OnlineShop.DAL.Entities;
using OnlineShop.PL.ViewModel;

namespace OnlineShop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public void Login(LoginViewModel model)
        {
            var user = new UserFactory().Create(model);
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public void Registration(RegistrationViewModel model)
        {
            var user = new UserFactory().Create(model);
        }
    }
}
