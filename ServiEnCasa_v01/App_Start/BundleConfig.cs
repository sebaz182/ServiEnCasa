﻿using System.Web;
using System.Web.Optimization;

namespace ServiEnCasa_v01
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datetimepicker.min.js",
                      "~/Scripts/moment-with-locales.js",
                      "~/Scripts/mainServienCasaJs.js"));

            bundles.Add(new ScriptBundle("~/bundles/typeahead").Include(
                      "~/Scripts/typeahead.bundle.js",
                      "~/Scripts/handlebars.js"));

            bundles.Add(new ScriptBundle("~/bundles/adminPanelJs").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.dcjqaccordion.2.7.js",
                      "~/Scripts/SeguridadDashboard.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/font-awesome/css/font-awesome.css",
                      "~/Content/bootstrap.css",
                      "~/Content/typeaheadjs.css",
                      "~/Content/SeguridadStyle.css",
                      "~/Content/bootstrap-datetimepicker.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/adminPanel").Include(
                 "~/Content/font-awesome/css/font-awesome.css",
                 "~/Content/bootstrap.css",
                  "~/Content/SeguridadDashboard.css",
                   "~/Content/SeguridadResponsiveDash.css"));

        }
    }
}
