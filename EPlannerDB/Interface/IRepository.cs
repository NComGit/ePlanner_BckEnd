using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB.Interface
{
    public interface IRepository : IDisposable
    {
        IQueryable<TodoItem> GetTodoItem();

        bool IsTodoItemExist(string title, string complete_incomplete);

        bool AddTodoItem(string title, string complete_incomplete);

        //I have no idea what im doing
    }
}