using System;
using System.Collections.Generic;
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

        public void Insert(Category obj)
        {
            db.Categories.Add(obj);
        }

        public IEnumerable<ToDo> SelectCatByUserID(string userId)
        {
            throw new NotImplementedException();
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
