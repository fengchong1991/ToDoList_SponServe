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


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<ToDo>().HasKey(t => t.Id);


            modelBuilder.Entity<ToDo>()
                .HasRequired(t => t.Category)
                .WithMany(c => c.ToDos)
                .HasForeignKey<int>(t => t.CategoryId);
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }
}
