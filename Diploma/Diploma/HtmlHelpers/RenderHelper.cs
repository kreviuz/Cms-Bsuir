using System.Linq;
using System.Web.Mvc;
using Diploma.DataHelpers;

namespace Diploma.HtmlHelpers
{
    public static partial class HtmlHelperExtensions
    {
        private static string GetPathToResource(ViewContext contect)
        {
            var path = ((RazorView)contect.View).ViewPath;
            path = path.Replace(Constants.Resources.ViewsPathPart, Constants.Resources.ResourcesPathPart);
            return path.Replace(Constants.Resources.CshtmlPathPart, Constants.Resources.XmlPathPart);
        }

        public static MvcHtmlString RenderTextWithGuid(this HtmlHelper helper, string guid)
        {
            var path = GetPathToResource(helper.ViewContext);
            var items = DtoHelper.ToTextItemModel(path);
            var mvcString = new MvcHtmlString(items.First(x => x.Guid == guid).Text);
            return mvcString;
        }

        public static MvcHtmlString RenderText(this HtmlHelper helper)
        {
            var path = GetPathToResource(helper.ViewContext);
            var items = DtoHelper.ToTextItemModel(path);
            var mvcString = new MvcHtmlString(items.First().Text);
            return mvcString;
        }
    }
}