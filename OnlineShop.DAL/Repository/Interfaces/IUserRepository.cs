using OnlineShop.DAL.Entities;
namespace OnlineShop.DAL.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User, string>
    {
        User GetItem(string userName, string passwordHash);
    }
}
