using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList_SponServe_Data
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<ToDo> ToDos { get; set; }

    }
}
