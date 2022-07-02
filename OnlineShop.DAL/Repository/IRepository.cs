using System;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository
{
    public interface IRepository<T>
    {
        void AddItem(T item);
        void DeleteItem(T item);
        void DeleteItemAt(int itemId);
        void GetItem(int Id);
        void GetList(Expression<Func<T, bool>> predicate);
    }
}
