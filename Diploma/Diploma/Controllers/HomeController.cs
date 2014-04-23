using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diploma.DataHelpers;
using Diploma.Models;

namespace Diploma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public void UrlPostData(string data, string path)
		{
			var items = DtoHelper.ToTextItemModel(path);
			var textItemModels = items as TextItemModel[] ?? items.ToArray();
			textItemModels.First().Text = data;
			DtoHelper.SerealizeModel(textItemModels, path);
		}
    }
}
