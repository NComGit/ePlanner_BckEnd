using EPlannerDB.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB
{
    public class Repository : IRepository
    {
        DBContext _Ctx;

        public Repository(DBContext Context)
        {
            _Ctx = Context;
            _Ctx.Context.Configuration.LazyLoadingEnabled = false;
            _Ctx.Context.Configuration.ProxyCreationEnabled = false;
        }

        public IQueryable<TodoItem> GetTodoItem()
        {
            return _Ctx.Context.TodoItems;
        }

        public bool AddTodoItem(string title, string complete_incomplete)
        {
            return true;
        }

        public bool IsTodoItemExist(string title, string complete_incomplete)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            if (_Ctx != null)
            {
                _Ctx.Dispose();
            }
        }


    }
}