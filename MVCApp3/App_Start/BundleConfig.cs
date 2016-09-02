using System.Web.Optimization;


namespace MVCApp3.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate"));
            bundles.Add(new ScriptBundle("~/Content/css").Include(
                "~/Content/boostrap.css", "~/Content/site.css"));
        }
    }
}