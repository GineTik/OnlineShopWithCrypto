using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Entities;

namespace OnlineShop.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public User Users { get; set; }
        public Category Categories { get; set; }
        public Comment Comments { get; set; }
        public Product Products { get; set; }
        public BasketItem Basket { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
