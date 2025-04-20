using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class MessagesController : Controller
    {
        // GET: MessagesController
        public ActionResult Index()
        {
            return View();
        }
    }
}
