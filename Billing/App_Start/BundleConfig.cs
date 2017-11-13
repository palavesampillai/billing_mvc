using System.Web;
using System.Web.Optimization;

namespace Billing
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));            

            bundles.Add(new StyleBundle("~/Content/themes/assets/css").Include(
                        "~/Content/themes/assets/css/bootstrap.min.css",
                        "~/Content/themes/assets/font-awesome/4.5.0/css/font-awesome.min.css",
                        "~/Content/themes/assets/css/fonts.googleapis.com.css",
                        "~/Content/themes/assets/css/ace.min.css",
                        "~/Content/themes/assets/css/ace-skins.min.css",
                        "~/Content/themes/assets/css/ace-rtl.min.css",
                        "~/Content/themes/assets/css/ace-ie.min.css"));
            bundles.Add(new ScriptBundle("~/Content/themes/assets/jsheader").Include(
                        "~/Content/themes/assets/js/ace-extra.min.js"));

            bundles.Add(new ScriptBundle("~/Content/themes/assets/jsfooter").Include(
                        "~/Content/themes/assets/js/jquery-2.1.4.min.js",
                        "~/Content/themes/assets/js/bootstrap.min.js",
                        "~/Content/themes/assets/js/jquery-ui.custom.min.js",
                        "~/Content/themes/assets/js/jquery.ui.touch-punch.min.js",
                        "~/Content/themes/assets/js/jquery.easypiechart.min.js",
                        "~/Content/themes/assets/js/jquery.sparkline.index.min.js",
                        "~/Content/themes/assets/js/jquery.flot.min.js",
                        "~/Content/themes/assets/js/jquery.flot.pie.min.js",
                        "~/Content/themes/assets/js/jquery.flot.resize.min.js",
                        "~/Content/themes/assets/js/ace-elements.min.js",
                        "~/Content/themes/assets/js/ace.min.js"));        
        }
    }
}