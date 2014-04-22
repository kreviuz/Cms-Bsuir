using System.Web.Mvc;
using Diploma.DataHelpers;

namespace Diploma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
