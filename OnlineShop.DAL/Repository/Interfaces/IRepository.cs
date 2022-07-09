using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository.Interfaces
{
    public interface IRepository<T, Tid>
    {
        void AddItem(T item);
        void DeleteItem(T item);
        void DeleteItemAt(Tid id);
        T GetItem(Tid id);
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate);
    }
}
