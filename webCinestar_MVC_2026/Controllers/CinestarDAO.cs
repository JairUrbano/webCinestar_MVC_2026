using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using webCinestar_MVC_2026.Models;

namespace webCinestar_MVC_2026.Controllers
{
    public class CinestarDAO
    {
        Db db = new Db("cnCinestar");
        internal List<Cine> getCines()
        {
            db.Sentencia("sp_getCines");
            DataTable dt = db.getDataTable();
            if (dt == null) return null;
            List<Cine> cines = new ArrayList<Cine>();
            foreach (DataRow dr in dt.Rows)
                cines.Add(new Cine(dr));
            return cines;
        }
    }
}