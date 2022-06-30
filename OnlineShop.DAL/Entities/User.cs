using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace OnlineShop.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateRegistration { get; set; }

        public List<BasketItem> Basket { get; set; }
    }
}
