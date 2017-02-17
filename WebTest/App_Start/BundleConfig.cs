using System.Configuration;
using System.Web;
using System.Web.Optimization;

namespace WebTest.AppStart
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Clear();
            bundles.ResetAll();
            bundles.UseCdn = true;
                        
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/jquery-1.9.1.js"));

            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/app", "*.js", true));
            
            bundles.Add(new StyleBundle("~/Content/CommonCss").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-theme.css" ));

            bundles.Add(new StyleBundle("~/Content/Style").Include(
                        "~/Content/style.css"));

        }
    }
}