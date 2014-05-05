using System.Web.Mvc;

namespace Diploma.Extensions
{
	public static class ResourceExtensions
	{
		public static string GetLocalResources(this WebViewPage page, string key)
		{
			return (string) page.ViewContext.HttpContext.GetLocalResourceObject(page.VirtualPath, key);
		}
	}
}