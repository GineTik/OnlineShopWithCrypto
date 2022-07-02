using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repository
{
    public class UserRepository : IRepository<User>
    {
        public void AddItem(User item)
        {
            
        }

        public void DeleteItem(User item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItemAt(int itemId)
        {
            throw new NotImplementedException();
        }

        public void GetItem(int Id)
        {
            throw new NotImplementedException();
        }

        public void GetList(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
