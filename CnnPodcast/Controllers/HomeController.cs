using System.Web.Mvc;

namespace CnnPodcast.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}