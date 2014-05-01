using System.Linq;
using System.Web.Mvc;
using Diploma.DataHelpers;
using Diploma.Models;

namespace Diploma.Controllers
{
    public class BaseController : Controller
    {
        [HttpPost]
        public JsonResult UrlPostData(string data, string path)
        {
            var items = DtoHelper.ToTextItemModel(path);
            var textItemModels = items as TextItemModel[] ?? items.ToArray();
            textItemModels.First().Text = data;
            DtoHelper.SerealizeModel(textItemModels, path);
            return Json(bool.TrueString);
        }
    }
}
