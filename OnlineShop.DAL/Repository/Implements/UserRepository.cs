using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository.Implements
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;    
        }

        public void AddItem(User item)
        {
            _db.Users.Add(item);
        }

        public void DeleteItem(User item)
        {
            _db.Users.Remove(item);
        }

        public void DeleteItemAt(string id)
        {
            User item = GetItem(id);
            DeleteItem(item);
        }

        public User GetItem(string id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetItem(string userName, string passwordHash)
        {
            return _db.Users.FirstOrDefault(u => u.UserName == userName && u.PasswordHash == passwordHash);
        }

        public IQueryable<User> GetList(Expression<Func<User, bool>> predicate)
        {
            return _db.Users.Where(predicate);
        }
    }
}
