using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace AdminUI.Web.Utilities.Extensions.Bootstrap
{
    public static class ControlLabelExtensions
    {
        public static MvcHtmlString ControlLabelWithColFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression, string colVal = "6")
        {
            return htmlHelper.LabelFor(expression, new { @class = "control-label col-sm-" + colVal });
        }
    }
}