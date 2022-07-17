using OnlineShop.DAL.EF;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Repository.Implements
{
    public class CommentRepository : ICommentRepository
    {
        private ApplicationDbContext _db;

        public CommentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddItem(Comment item)
        {
            _db.Comments.Add(item);
            SaveChanges();
        }

        public void DeleteItem(Comment item)
        {
            _db.Comments.Remove(item);
            SaveChanges();
        }

        public void DeleteItemAt(int id)
        {
            var item = GetList(c => c.Id == id).FirstOrDefault();
            DeleteItem(item);
        }

        public Comment GetItem(int id)
        {
            return _db.Comments.FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<Comment> GetList(Expression<Func<Comment, bool>> predicate)
        {
            return _db.Comments.Where(predicate);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
