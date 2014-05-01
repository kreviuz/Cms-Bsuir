using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diploma.DataHelpers;
using Diploma.Models;

namespace Diploma.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
