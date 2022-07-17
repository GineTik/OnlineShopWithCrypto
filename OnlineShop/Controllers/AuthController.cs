using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.BLL.Factories;
using OnlineShop.BLL.Services.Implementation;
using OnlineShop.BLL.Services.Interfaces;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using OnlineShop.PL.ViewModel;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class AuthController : Controller
    {
        
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid == true)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, false);

                if (result.Succeeded == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Такой пользователь не зарегистрирован");
                }
            }
            return View(model);
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid == false)
                return View(model);

            var user = new UserFactory().Create(model);
            // добавляем пользователя
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded == true)
            {
                // установка куки
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
    }
}
