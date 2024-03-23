using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlannerDB
{
    public class DBContext
    {
        EPlannerDBEntities _Ctx;

        public DBContext()
        {
            _Ctx = new EPlannerDBEntities();
        }

        public EPlannerDBEntities Context
        {
            get
            {
                return this._Ctx;
            }
        }

        public void Dispose()
        {
            if (_Ctx != null) { _Ctx.Dispose(); }
        }
    }
}
