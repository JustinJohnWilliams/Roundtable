using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Roundtable.Web.Utility.Helpers
{
    public static class NavLinkHelpers
    {
        public static MvcHtmlString NavLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string areaName = null)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            var builder = new TagBuilder("li")
            {
                InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName, new { area = areaName ?? "" }, new { }).ToHtmlString()
            };

            if (controllerName.Equals(currentController, StringComparison.InvariantCultureIgnoreCase))
                builder.AddCssClass("active");

            //MvcHtmlString automagically encoded
            return new MvcHtmlString(builder.ToString());
        }

    }
}