using OnlineShop.BLL.Hashers;
using OnlineShop.DAL.Entities;
using OnlineShop.PL.ViewModel;
using System;
using System.Security.Claims;

namespace OnlineShop.BLL.Factories
{
    public class UserFactory
    {
        public User Create(LoginViewModel model)
        {
            return new User()
            {
                Email = model.Email,
                //PasswordHash = PasswordHasher.HashPassword(model.Password)
            };
        }

        public User Create(RegistrationViewModel model)
        {
            return new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateRegistration = DateTime.Now,
                //PasswordHash = PasswordHasher.HashPassword(model.Password)
            };
        }
    }
}
