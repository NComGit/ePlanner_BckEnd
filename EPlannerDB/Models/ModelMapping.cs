using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB.Models
{
    public class ModelMapping
    {
        public User GetUser(EPlannerDB.User user)
        {
            return new User
            {
                id = user.id,
                username = user.username,
                password = user.password,
            };
        }
        public TodoItem GetTodoItem(EPlannerDB.TodoItem item)
        {
            return new TodoItem
            {
                id = item.id,
                todoListId = item.todoListId,
                title = item.title,
                complete_incomplete = item.complete_incomplete,
                userDelegatedToId = item.userDelegatedToId,
                dueDate = item.dueDate,
            };
        }
        public TodoList GetTodoList(EPlannerDB.TodoList list)
        {
            return new TodoList
            {
                id = list.id,
                userId = list.userId,
                title = list.title,
                description = list.description,
            };
        }
        public TodoListAccess GetTodoListAccess(EPlannerDB.TodoListAccess access)
        {
            return new TodoListAccess
            {
                id = access.id,
                todoListId = access.todoListId,
                userId = access.userId,
            };
        }
    }
}
