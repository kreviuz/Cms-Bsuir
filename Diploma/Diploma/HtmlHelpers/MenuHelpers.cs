using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Diploma.HtmlHelpers
{
    public static partial class HtmlHelperExtensions
    {
        public static MvcHtmlString MenuLink(this HtmlHelper helper, string text, string action, string controller)
        {
            var routeData = helper.ViewContext.RouteData.Values;
            var currentController = (string)routeData["controller"];
            var currentAction = (string)routeData["action"];

            if (String.Equals(action, currentAction, StringComparison.OrdinalIgnoreCase) && String.Equals(controller, currentController, StringComparison.OrdinalIgnoreCase))
            {
                return helper.ActionLink(text, action, controller, null, new { @class = "menu-top-item-active" });
            }
            return helper.ActionLink(text, action, controller);
        }
    }
}