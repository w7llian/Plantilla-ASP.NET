using System.Web;
using System.Web.Optimization;

namespace TiendaPrueba
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Content/js/sweet-alert.min.js",
                    "~/Content/js/modernizr.js",
                    "~/Content/js/jquery-1.11.2.min.js",
                    "~/Content/js/jquery.mCustomScrollbar.concat.min.js",
                    "~/url//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js",
                    "~/Content/js/bootstrap.min.js",
                    "~/Content/js/main.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/url//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/icons/book.ico",
                      "~/Content/css/sweet-alert.css",
                      "~/Content/css/material-design-iconic-font.min.css",
                      "~/Content/css/normalize.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/jquery.mCustomScrollbar.css",
                      "~/Content/css/style.css",
                      "~/Content/css/login.css"));
        }
    }
}
