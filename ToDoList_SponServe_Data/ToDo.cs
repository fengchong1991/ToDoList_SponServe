using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ToDoList_SponServe_Data
{
    public class ToDo
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
