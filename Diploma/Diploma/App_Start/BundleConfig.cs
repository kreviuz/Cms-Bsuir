using System.Web.Optimization;

namespace Diploma.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }
        private static void RegisterScripts(BundleCollection bundles)
        {
            var jqueryBundle = new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js");
            bundles.Add(jqueryBundle);
        }
        private static void RegisterStyles(BundleCollection bundles)
        {
            var layoutBundle = new StyleBundle("~/bundles/less/main").Include(
                       "~/Content/layout_style.css");
            bundles.Add(layoutBundle);
        }
    }
}