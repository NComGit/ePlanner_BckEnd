using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB.Models
{
    public class TodoItem
    {
        public int id { get; set; }
        public int todoListId { get; set; }
        public string title { get; set; }
        public string complete_incomplete { get; set; }
        public Nullable<int> userDelegatedToId { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
    }
}