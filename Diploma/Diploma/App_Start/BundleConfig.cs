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
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/redactor/redactor.js",
                        "~/Scripts/modules/editor_module.js");
            bundles.Add(jqueryBundle);
        }
        private static void RegisterStyles(BundleCollection bundles)
        {
            var layoutBundle = new StyleBundle("~/bundles/css/main").Include(
                       "~/Content/Style/layout_style.css",
                        "~/Content/Style/menu_style.css",
                       "~/Content/redactor/redactor.css");
            bundles.Add(layoutBundle);
        }
    }
}