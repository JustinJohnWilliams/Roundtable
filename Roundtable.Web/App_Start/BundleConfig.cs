using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Roundtable.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles()
        {
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            BundleTable.Bundles.Add(new StyleBundle("~/Content/bootstrap/base").Include("~/Content/bootstrap/bootstrap.css", "~/Content/bootstrap/bootstrap-theme.css", "~/Content/site.css"));
            BundleTable.Bundles.Add(new StyleBundle("~/Content/base").Include("~/Content/Site.css"));
            
        }
    }
}