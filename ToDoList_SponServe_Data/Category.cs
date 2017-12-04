using System.ComponentModel.DataAnnotations;


namespace ToDoList_SponServe_Data
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string UserId { get; set; }

    }
}
