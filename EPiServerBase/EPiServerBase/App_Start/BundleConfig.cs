using System.Web.Optimization;

namespace EPiServerBase.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/bundles/bootstrap")
                .Include("~/Content/bootstrap.css"));
        }
    }
}