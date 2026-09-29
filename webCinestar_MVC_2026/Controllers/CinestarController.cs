using System.Web.Mvc;

namespace webCinestar_MVC_2026.Controllers
{
    public class CinestarController : Controller
    {
        CinestarDAO cinestarDAO = new CinestarDAO();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cines()
        {
            return View(cinestarDAO.getCines() );
        }
    }
}