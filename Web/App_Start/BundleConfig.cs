using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/Main/Css/about.css",
               "~/Content/Main/Css/account.css",
               "~/Content/Main/Css/blog.css",
               "~/Content/Main/Css/cart.css",
               "~/Content/Main/Css/checkout.css",
               "~/Content/Main/Css/contact.css",
               "~/Content/Main/Css/home2.css",
               "~/Content/Main/Css/main.css",
               "~/Content/Main/Css/responsive.css",
               "~/Content/Main/Js/dropKick/dropkick.css",
               "~/Content/Main/Js/fancybox/jquery.fancybox-1.3.4.css",
                 "~/Content/Main/Css/bootstrap.min.css",
                 "~/Content/Main/Css/Zoom.css"

               ));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
               "~/Content/Admin/assets/bootstrap/css/bootstrap.min.css",
               "~/Content/Admin/assets/bootstrap/css/bootstrap.min.css",
               "~/Content/Admin/assets/bootstrap/css/bootstrap-responsive.min.css",
               "~/Content/Admin/assets/font-awesome/css/font-awesome.css.css",
               "~/Content/Admin/css/style_responsive.css",
               "~/Content/Admin/css/bootstrap-responsive.min.css",
               "~/Content/Admin/css/bootstrap.min.css",
               "~/Content/Admin/css/style.css",
               "~/Content/Admin/css/style_responsive.css",
               "~/Content/Admin/css/style_default.css",
               "~/Content/Admin/assets/fancybox/source/jquery.fancybox.css",
               "~/Content/Admin/Css/assets/uniform/css/uniform.default.css",
               "~/Content/Admin/assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css",
               "~/Content/Admin/assets/jqvmap/jqvmap/jqvmap.css"
               ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}