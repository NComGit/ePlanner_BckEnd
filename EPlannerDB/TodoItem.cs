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
    
    public partial class TodoItem
    {
        public int id { get; set; }
        public int todoListId { get; set; }
        public string title { get; set; }
        public string complete_incomplete { get; set; }
        public Nullable<int> userDelegatedToId { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
    
        public virtual TodoList TodoList { get; set; }
        public virtual User User { get; set; }
    }
}