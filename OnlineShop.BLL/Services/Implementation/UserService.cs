using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using OnlineShop.DAL.Entities;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;


namespace OnlineShop.BLL.Services.Implementation
{
    public class UserService
    {
        public HttpContext HttpContext { get; }

        public UserService(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }

        public async Task SignInAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("Id", user.Id),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName),
                new Claim("DateRegistration", user.DateRegistration.ToString()),
                new Claim(ClaimTypes.Role, "User"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
               CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity));
        }

        public async Task SignOutAsync()
        {
            await HttpContext.SignOutAsync();
        }

        public User GetUser()
        {
            HttpContext.User
        }
    }
}
