using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository.Implements
{
    public class BasketRepository : IBasketRepository
    {
        private ApplicationDbContext _db;

        public BasketRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddItem(BasketItem item)
        {
            _db.Basket.Add(item);
        }

        public void DeleteItem(BasketItem item)
        {
            _db.Basket.Remove(item);
        }

        public void DeleteItemAt(int id)
        {
            var item = GetItem(id);
            DeleteItem(item);
        }

        public BasketItem GetItem(int id)
        {
            return _db.Basket.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<BasketItem> GetList(Expression<Func<BasketItem, bool>> predicate)
        {
            return _db.Basket.Where(predicate);
        }
    }
}
