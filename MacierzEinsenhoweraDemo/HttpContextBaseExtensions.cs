using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacierzEinsenhoweraDemo
{
    public static class HttpContextBaseExtensions
    {
        public static JsTemplatesContext GetJsTemplatesContext(this HttpContextBase httpContext)
        {
            const string key = "JsTemplatesContext";

            if (httpContext.Items != null)
            {
                if (httpContext.Items.Contains(key))
                {
                    return httpContext.Items[key] as JsTemplatesContext;
                }

                var result = new JsTemplatesContext();
                httpContext.Items[key] = result;

                return result;
            }

            return null;
        }
    }
}