using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class PagesController : Controller
    {
        // GET: PagesController
        public ActionResult Index()
        {
            return View();
        }
    }
}
