using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ACME.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/dist/css/adminlte.min.css",

                "~/plugins/fontawesome-free/css/all.min.css",
                "~/plugins/icheck-bootstrap/icheck-bootstrap.min.css"
                ));

            //lib css
            bundles.Add(new StyleBundle("~/Content/libcss").Include(
                "~/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                "~/plugins/select2/css/select2.min.css",
                "~/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
                "~/plugins/jqvmap/jqvmap.min.css",
                "~/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                "~/plugins/daterangepicker/daterangepicker.css",
                "~/plugins/summernote/summernote-bs4.css",
                "~/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css",
                "~/plugins/datatables-bs4/css/dataTables.bootstrap4.css",
                "~/plugins/raty/jquery.raty.css",
                "~/dist/js/googlefonts.css",
                "~/plugins/toastr/toastr.min.css"
                ));

            //lib css
            //bundles.Add(new StyleBundle("~/Content/toastr").Include(
            //    "~/plugins/toastr/toastr.min.css"));


            // JQuery

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/plugins/jquery/jquery.min.js",
                      "~/plugins/bootstrap/js/bootstrap.min.js",
                      "~/plugins/bootstrap/js/bootstrap.bundle.min.js"));



            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/plugins/jquery-ui/jquery-ui.min.js",
                "~/dist/js/jquery.validate.min.js",
                "~/scripts/jquery.unobtrusive-ajax.min.js",
                "~/dist/js/jquery.validate.unobtrusive.min.js"
                     ));

            //JQ lib
            bundles.Add(new ScriptBundle("~/bundles/libjs").Include(
              "~/plugins/jqvmap/jquery.vmap.min.js",
              "~/plugins/moment/moment.min.js",
              "~/plugins/daterangepicker/daterangepicker.js",
              "~/dist/js/adminlte.js",
              //"~/dist/js/pages/dashboard.js",
              "~/dist/js/demo.js",
              "~/plugins/toastr/toastr.min.js",
              "~/plugins/select2/js/select2.min.js",
              "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
              "~/plugins/bs-custom-file-input/bs-custom-file-input.min.js",
              "~/dist/js/adminlte.js"
              , "~/plugins/raty/jquery.raty.js",
              "~/plugins/sweetalert2/sweetalert2.min.js",
              "~/plugins/toastr/toastr.min.js",
              "~/plugins/moment/moment.min.js",
               "~/plugins/daterangepicker/daterangepicker.js"

              ));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
              "~/plugins/datatables/jquery.dataTables.js",
              "~/plugins/datatables-bs4/js/dataTables.bootstrap4.js"
              ));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
               "~/plugins/chart.js/Chart.min.js"));
        }
    }
}