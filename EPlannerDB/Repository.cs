using EPlannerDB.Interfaces;
using System;
using System.Collections.Generic;
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

        public void Dispose()
        {
            if (_Ctx != null )
            {
                _Ctx.Dispose();
            }
        }
    }
}
