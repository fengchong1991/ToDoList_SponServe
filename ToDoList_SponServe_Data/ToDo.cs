using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ToDoList_SponServe_Data
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public int Urgency { get; set; }
        public bool Finished { get; set; }
    

        public virtual Category Category { get; set; }

    }
}
