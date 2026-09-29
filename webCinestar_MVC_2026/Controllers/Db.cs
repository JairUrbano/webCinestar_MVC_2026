using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace webCinestar_MVC_2026.Controllers
{
    public class Db
    {
        private string v;

        public Db(string v)
        {
            this.v = v;
        }

        internal DataTable getDataTable()
        {
            throw new NotImplementedException();
        }

        internal void Sentencia(string v)
        {
            throw new NotImplementedException();
        }
    }
}