using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_SponServe_Data
{
    class ToDos
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("UserId")]
        public virtual AspNetUser User { get; set; }

    }
}
