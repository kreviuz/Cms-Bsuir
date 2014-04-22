using System;
using System.Web.Mvc;

namespace Diploma.HtmlHelpers
{
    public static partial class HtmlHelperExtensions
    {
        public static MvcHtmlString InitModule(this HtmlHelper helper, string name, object parameters)
        {
            return new MvcHtmlString(String.Empty);
        }
    }
}