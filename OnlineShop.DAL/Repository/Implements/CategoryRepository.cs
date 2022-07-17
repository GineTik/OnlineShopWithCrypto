using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repository.Implements
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddItem(Category item)
        {
            _db.Categories.Add(item);
            SaveChanges();
        }

        public void DeleteItem(Category item)
        {
            _db.Categories.Remove(item);
            SaveChanges();
        }

        public void DeleteItemAt(int id)
        {
            var item = GetItem(id);
            DeleteItem(item);
        }

        public Category GetItem(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public IQueryable<Category> GetList(Expression<Func<Category, bool>> predicate)
        {
            return _db.Categories.Where(predicate);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
