using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
    }
}
