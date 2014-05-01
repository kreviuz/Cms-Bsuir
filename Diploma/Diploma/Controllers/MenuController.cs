using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diploma.Controllers
{
    public class MenuController : Controller
    {
        public PartialViewResult Index()
        {
            var result = PartialView();
            return result;
        }
    }
}
