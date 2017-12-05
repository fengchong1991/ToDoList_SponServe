using System;
using System.Collections.Generic;
using ToDoList_SponServe_Data;

namespace ToDoList_SponServe_DAL.Repository
{
    public class ToDoRepo : IRepo<ToDo, string>
    {
        private AppDbContext db;

        public ToDoRepo()
        {
            this.db = new AppDbContext();
        }

        public void Insert(ToDo obj)
        {
            db.ToDos.Add(obj);
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
