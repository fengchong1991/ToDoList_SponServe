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

        public ToDo Insert(ToDo obj)
        {
            return db.ToDos.Add(obj);
        }

        public int MarkToDoComplete(int Id)
        {
            var todo = db.ToDos.Find(Id);
            todo.Finished = true;
            return todo.CategoryId;
        }

        public void DeleteToDo(int Id)
        {
            ToDo toDOToDelete = new ToDo() { Id = Id };
            db.Entry(toDOToDelete).State = System.Data.Entity.EntityState.Deleted;
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
