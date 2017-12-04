using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ToDoList_SponServe_Data;

namespace ToDoList_SponServe_DAL
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext() : base("name=ToDoList")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ToDo> ToDos { get; set; }


        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }
}
