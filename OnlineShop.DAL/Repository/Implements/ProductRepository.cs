using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository.Implements
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddItem(Product item)
        {
            _db.Products.Add(item);
        }

        public void DeleteItem(Product item)
        {
            _db.Products.Remove(item);
        }

        public void DeleteItemAt(int id)
        {
            var item = GetItem(id);
            DeleteItem(item);
        }

        public Product GetItem(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<Product> GetList(Expression<Func<Product, bool>> predicate)
        {
            return _db.Products.Where(predicate);
        }
    }
}
