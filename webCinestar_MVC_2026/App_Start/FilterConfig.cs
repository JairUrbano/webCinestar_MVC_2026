using System.Web;
using System.Web.Mvc;

namespace webCinestar_MVC_2026
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
