﻿using System.Web;
using System.Web.Optimization;

namespace SignalR.Event.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/api").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.signalR-{version}.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/angular.js",
                "~/Scripts/ng-grid.js"));

            bundles.Add(new ScriptBundle("~/bundles/eventAggregator").Include(
                "~/Scripts/jquery.signalR.eventAggregator-{version}.js",
                "~/Scripts/jquery.signalR.eventAggregator.angular-{version}.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory(
                "~/Scripts/App", "*.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/ng-grid.css"));
        }
    }
}