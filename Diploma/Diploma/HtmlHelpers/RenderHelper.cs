using System.Linq;
using System.Web.Mvc;
using Diploma.DataHelpers;

namespace Diploma.HtmlHelpers
{
    public static partial class HtmlHelperExtensions
    {
        public static MvcHtmlString RenderTextWithGuid(this HtmlHelper helper, string guid)
        {
            var items = DtoHelper.ToTextItemModel();
            var mvcString = new MvcHtmlString(items.First(x => x.Guid == guid).Text);
            return mvcString;
        }
    }
}