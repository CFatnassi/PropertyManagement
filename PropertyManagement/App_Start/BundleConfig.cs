using System.Web;
using System.Web.Optimization;

namespace PropertyManagement
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //var lessBundle = new Bundle("~/My/Less").IncludeDirectory("~/My", "*.less");
            //lessBundle.Transforms.Add(new LessTransform());
            //lessBundle.Transforms.Add(new CssMinify());
            //bundles.Add(lessBundle);
            BundleTable.EnableOptimizations = true;


            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                 "~/Scripts/app/job.js"


                ));

            bundles.Add(new Bundle("~/bundles/MainJS").Include(
                 "~/Scripts/jquery-{version}.js",


                             "~/Scripts/bootstrap.min.js",


                             "~/Scripts/bootbox.js",



                              "~/Scripts/toastr.js",
                                //"~/Scripts/bootstrap-datepicker.min.js",
                                "~/Scripts/jquery-1.11.3.min.js"




                ));
            bundles.Add(new Bundle("~/bundles/mainBudle").Include(
                "~/vendors/bower_components/jquery/dist/jquery.min.js",
  "~/vendors/jquery-ui.min.js",
 "~/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js",
"~/src/js/vendors.min.js",
"~/src/js/pages/chat-popup.js",
"~/assets/icons/feather-icons/feather.min.js",
"~/assets/vendor_components/jquery-toast-plugin-master/src/jquery.toast.js",


"~/Scripts/toastr.js",
"~/Scripts/bootbox.js"

               ));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate.js",
            //            "~/Scripts/jquery.validate.min.js",
            //            "~/Scripts/jquery.validate.unobtrusive.js",
            //            "~/Scripts/jquery.validate.unobtrusive.min.js",
            //            "~/Scripts/jquery.validate-vsdoc.js"
            //            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new StyleBundle("~/Content/AllMyCss").Include(


                                "~/Content/typeahead.css",


                "~/Content/vendors/bower_components/datatables/media/css/jquery.dataTables.min.css",

                "~/Content/vendors/bower_components/jquery-toast-plugin/dist/jquery.toast.min.css",

                "~/Content/dist/css/style.css",
                      "~/Content/dist/css/style.scss",
                            "~/Content/metisMenu.css",

                             "~/Content/toastr.css",

 "~/Content/vendors/bower_components/switchery/dist/switchery.min.css",
   "~/Content/dist/css/fancy-buttons.css",
    "~/Content/multi-select.css",
                                     "~/Content/multi-select.dev.css",
                                     "~/Content/multi-select.dist.css",
                                    "~/Content/dataTables.checkboxes.css",
                                      "~/Content/jquery.dataTables.min.css",
                                         "~/Content/select.dataTables.min.css",
                                           "~/Content/bootstrap-multiselect.css",
                                         "~/Content/NaghamStyle.css"








                      ));


            bundles.Add(new Bundle("~/bundles/jqueryval").Include(
                 "~/Scripts/jquery.validate*",
                 "~/assets/icons/feather-icons/feather.min.js",
                 "~/assets/vendor_components/datatable/datatables.min.js",
                   "~/assets/vendor_components/select2/dist/js/select2.full.js",
                 "~/src/js/pages/data-table.js",
                 "~/Scripts/moment.js",
                 "~/Scripts/jquery.maskedinput.min.js",
                 "~/Scripts/dataTables.checkboxes.min.js",
                 "~/Scripts/dataTables.select.min.js",
                 "~/Scripts/jquery.multi-select.js",
                  "~/Scripts/bootstrap-multiselect.js",

                 "~/Scripts/jquery-ui.js"

                 ));


            bundles.Add(new StyleBundle("~/Content/AllMyCss-rtl").Include(


                                "~/Content/typeahead.css",

                "~/Content/vendors/bower_components/datatables/media/css/jquery.dataTables.min.css",

                "~/Content/vendors/bower_components/jquery-toast-plugin/dist/jquery.toast.min.css",

                "~/Content/RTL/dist/css/style.css",
                      "~/Content/style-rtl.scss",
                            "~/Content/metisMenu.css",

                             "~/Content/toastr.css",

 "~/Content/vendors/bower_components/switchery/dist/switchery.min.css",
   "~/Content/RTL/dist/css/fancy-buttons.css",
    "~/Content/multi-select.css",
                                     "~/Content/multi-select.dev.css",
                                     "~/Content/multi-select.dist.css",
                                     "~/Content/dataTables.checkboxes.css",
                                     "~/Content/jquery.dataTables.min.css",
                                         "~/Content/select.dataTables.min.css",

                                         "~/Content/NaghamStyle.css"




        ));

        }
    }
}
