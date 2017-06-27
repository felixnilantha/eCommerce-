using System.Web;
using System.Web.Optimization;

namespace eCommerce.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
               "~/wwwroot/lib/jquery/dist/jquery.js",
               "~/wwwroot/lib/jquery-ui/jquery-ui.js"
           ));
            bundles.Add(new ScriptBundle("~/bundles/angular")
               .Include("~/wwwroot/lib/angular/angular.js"));



            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/wwwroot/lib/bootstrap/dist/js/bootstrap.js",
                "~/wwwroot/lib/bootstrap-datepicker/dist/js/bootstrap-datepicker.js",
                "~/wwwroot/lib/angular-ui-notification/dist/angular-ui-notification.js",
                "~/wwwroot/lib/spectrum/spectrum.js",
                "~/wwwroot/lib/angular-spectrum-colorpicker/dist/angular-spectrum-colorpicker.js",
                "~/wwwroot/lib/js-custom-select/js/customSelect.js",
                "~/wwwroot/lib/datatables/media/jquery.dataTables.min.js",
                "~/wwwroot/lib/datatables-colvis/media/jquery.dataTables.colVis.js",
                "~/wwwroot/lib/jquery-ui/jquery-ui.min.js",
                "~/wwwroot/lib/angular-ui-sortable/sortable.js",
                "~/wwwroot/lib/datatables/media/js/jquery.dataTables.min.js",
                "~/wwwroot/lib/angular-datatables/dist/angular-datatables.min.js",
                "~/wwwroot/lib/select2/dist/js/select2.min.js",
                "~/wwwroot/lib/angular-bootstrap/ui-bootstrap.js",
                "~/wwwroot/lib/angular-bootstrap/ui-bootstrap-tpls.js"
             ));


        }
    }
}
