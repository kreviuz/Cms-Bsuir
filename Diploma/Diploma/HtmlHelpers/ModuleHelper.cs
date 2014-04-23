using System;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Diploma.HtmlHelpers
{
    public static partial class HtmlHelperExtensions
    {
        public static MvcHtmlString InitModule(this HtmlHelper helper, string name, object parameters)
        {
			var result = new StringBuilder();
			var jsonInitParams = JsonConvert.SerializeObject(parameters, new JavaScriptDateTimeConverter());

			result.Append("<script type=\"text/javascript\">");
			result.Append(String.Format("$(function () {{ new {0}(", name));
			result.Append(jsonInitParams);
			result.Append(");});");
			result.Append("</script>");
			result.Append(Environment.NewLine);

			return MvcHtmlString.Create(result.ToString());
        }
    }
}