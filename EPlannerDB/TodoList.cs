//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPlannerDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TodoList
    {
        public TodoList()
        {
            this.TodoItems = new HashSet<TodoItem>();
            this.TodoListAccesses = new HashSet<TodoListAccess>();
        }
    
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<TodoItem> TodoItems { get; set; }
        public virtual ICollection<TodoListAccess> TodoListAccesses { get; set; }
        public virtual User User { get; set; }
    }
}