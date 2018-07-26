using System.Web;
using System.Web.Optimization;

namespace SalesSys
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            
            bundles.Add(new ScriptBundle("~/template/jquerymask").Include(
                "~/plugins/input-mask/jquery.inputmask.js",
                "~/plugins/input-mask/jquery.inputmask.date.extensions.js",
                "~/plugins/input-mask/jquery.inputmask.extensions.js",
                "~/plugins/input-mask/jquery.inputmask.numeric.extensions.js",
                "~/plugins/input-mask/jquery.inputmask.phone.extensions.js",
                "~/plugins/input-mask/jquery.inputmask.regex.extensions.js"
                ));


            bundles.Add(new ScriptBundle("~/bundle/aditional_plugins").Include(
                "~/plugins/slimScroll/jquery.slimscroll.min.js",
                "~/plugins/select2/select2.js",
                "~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                "~/plugins/knob/jquery.knob.js",
                "~/plugins/datatables/jquery.dataTables.min.js",
                "~/plugins/datatables/dataTables.bootstrap.min.js",
                "~/plugins/daterangepicker/daterangepicker.js",
                "~/plugins/datepicker/bootstrap-datepicker.js",
                "~/plugins/fullcalendar/fullcalendar.min.js",
                "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                "~/plugins/colorpicker/bootstrap-colorpicker.min.js",
                "~/plugins/timepicker/bootstrap-timepicker.min.js",
                "~/plugins/iCheck/icheck.min.js",
                "~/plugins/fastclick/fastclick.js",
                "~/dist/js/adminlte.min.js",
                "~/plugins/sparkline/jquery.sparkline.min.js",
                "~/dist/js/pages/dashboard.js"
                ));

            bundles.Add(new StyleBundle("~/Content/aditional_styles").Include(
                "~/plugins/datepicker/datepicker3.css",
                "~/plugins/daterangepicker/daterangepicker.css",
                "~/plugins/iCheck/all.css",
                "~/plugins/colorpicker/bootstrap-colorpicker.min.css",
                "~/plugins/timepicker/bootstrap-timepicker.min.css",
                "~/plugins/select2/select2.min.css",
                "~/dist/css/AdminLTE.min.css",
                "~/dist/css/skins/_all-skins.min.css",
                "~/plugins/datatables/dataTables.bootstrap.css",
                "~/plugins/fullcalendar/fullcalendar.min.css",
                "~/plugins/fullcalendar/fullcalendar.print.css",
                "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
               ));

            bundles.Add(new ScriptBundle("~/bundles/url_ajax_manager").Include(
              "~/Scripts/url.ajax.manager-{version}.js"
              ));
        }
    }
}

          
        
    

