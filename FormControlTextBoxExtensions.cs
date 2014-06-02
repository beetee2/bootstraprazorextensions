using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace AdminUI.Web.Utilities.Extensions.Bootstrap
{
    public static class FormControlTextBoxExtensions
    {
        public static MvcHtmlString FormControlTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression)
        {
            return htmlHelper.FormControlTextBoxFor(expression, htmlAttributes: null);
        }

        public static MvcHtmlString FormControlTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, object htmlAttributes)
        {
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            AddClassAttributes(attributes);
            return htmlHelper.TextBoxFor(expression, attributes);
        }

        public static MvcHtmlString FormControlPasswordFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, object htmlAttributes = null)
        {
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            AddClassAttributes(attributes);
            return htmlHelper.PasswordFor(expression, attributes);
        }

        private static void AddClassAttributes(RouteValueDictionary attributes)
        {
            if (attributes.ContainsKey("class"))
            {
                var attributeString = attributes["class"].ToString().ToLower().Trim();
                if (!attributeString.Contains("form-control"))
                {
                    attributes["class"] = (attributes["class"] + " form-control").Trim();
                }
            }
            else
            {
                attributes.Add("class", "form-control");
            }
        }
    }
}