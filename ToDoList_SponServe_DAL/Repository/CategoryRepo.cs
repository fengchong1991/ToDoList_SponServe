using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_SponServe_Data;

namespace ToDoList_SponServe_DAL.Repository
{
    public class CategoryRepo : IRepo<Category, string>
    {
        private AppDbContext db;

        public CategoryRepo()
        {
            this.db = new AppDbContext();
        }

        public Category Insert(Category obj)
        {
            return db.Categories.Add(obj);
        }

        public IEnumerable<Category> SelectCatByUserID(string userId)
        {
            return db.Categories.Where(c => c.UserId == userId).Include(c => c.ToDos).ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
