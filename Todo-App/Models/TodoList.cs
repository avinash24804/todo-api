using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models
{
    public class TodoList
    {
        [Required]
        [Key]
        public int  sno { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
