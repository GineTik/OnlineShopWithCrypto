using OnlineShop.DAL.Entities;
using System.Threading.Tasks;

namespace OnlineShop.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task SignInAsync(User user);
        Task SignOutAsync();
        User GetUser();
    }
}
