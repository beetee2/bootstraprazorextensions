using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace AdminUI.Web.Utilities.Extensions.Bootstrap
{
    public static class DisplayFieldExtensions
    {
        public static MvcHtmlString DisplayFieldSpanFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression)
        {
            return MvcHtmlString.Create(string.Format("<div class='display-field'><span>{0}</span></div>", helper.DisplayFor(expression)));
        }

        public static MvcHtmlString DisplayFieldSpanWithColFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, string colVal = "6")
        {
            return MvcHtmlString.Create(string.Format("<div class=\"col-sm-" + colVal + "\"><div class='display-field'><span>{0}</span></div></div>", helper.DisplayFor(expression), colVal));
        }

        public static MvcHtmlString DisplayCheckboxWithColFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, string colVal = "6")
        {
            return MvcHtmlString.Create(string.Format("<div class=\"col-sm-" + colVal + "\"><div class='checkbox'>{0}</div></div>", helper.DisplayFor(expression), colVal));
        }
    }
}