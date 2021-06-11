using System.Web;
using System.Web.Optimization;

namespace Otel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/js/jquery-1.11.0.min.js",
                            "~/js/bootstrap.min.js",
                            "~/js/bootstrap-hover-dropdown.min.js",
                            "~/js/owl.carousel.min.js",
                            "~/js/jquery.parallax-1.1.3.js",
                            "~/js/jquery.nicescroll.js",
                            "~/js/jquery.prettyPhoto.js",
                            "~/js/jquery-ui-1.10.4.custom.min.js",
                            "~/js/jquery.forms.js",
                            "~/js/jquery.sticky.js",
                            "~/js/waypoints.min.js",
                            "~/js/jquery.isotope.min.js",
                            "~/js/jquery.gmap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery2").Include(
                            "~/rs-plugin/js/jquery.themepunch.tools.min.js",
                            "~/rs-plugin/js/jquery.themepunch.revolution.min.js",
                            "~/js/custom.js"));

            bundles.Add(new StyleBundle("~/css").Include(
                            "~/css/animate.css",
                            "~/css/bootstrap.css",
                            "~/css/font-awesome.min.css",
                            "~/css/owl.carousel.css",
                            "~/css/owl.theme.css",
                            "~/css/prettyPhoto.css",
                            "~/css/smoothness/jquery-ui-1.10.4.custom.min.css",
                            "~/rs-plugin/css/settings.css",
                            "~/css/theme.css",
                            "~/css/colors/turquoise.css",
                            "~/css/responsive.css"));


            //* Admin *//

            bundles.Add(new StyleBundle("~/assets/css/styles.css").Include(
                      "~/assets/css/styles.css",
                      "~/assets/demo/variations/header-blue.css"));

            bundles.Add(new StyleBundle("~/assets/css/ie8.css").Include(
                      "~/assets/css/ie8.css"));

            bundles.Add(new ScriptBundle("~/assets/js/plugin-before").Include(
                      "~/assets/js/jqueryui-1.10.3.min.js",
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/js/enquire.js",
                      "~/assets/js/jquery.cookie.js",
                      "~/assets/js/jquery.nicescroll.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/plugin-after").Include(
                      "~/assets/js/placeholdr.js",
                      "~/assets/js/application.js"));

            bundles.Add(new ScriptBundle("~/Template/js/master_core.js").Include(
                      "~/Template/js/master_core.js"));

            bundles.Add(new ScriptBundle("~/Template/js/showLoading.js").Include(
                     "~/Template/js/showLoading.js"));

            bundles.Add(new StyleBundle("~/Template/css/master_styles.css").Include(
                      "~/Template/css/master_styles.css"));



            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            
        }
    }
}
