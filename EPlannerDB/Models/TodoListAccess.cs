using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB.Models
{
    public class TodoListAccess
    {
        public int id { get; set; }
        public int todoListId { get; set; }
        public int userId { get; set; }
    }
}