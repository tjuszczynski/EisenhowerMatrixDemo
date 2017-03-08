using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacierzEinsenhoweraDemo
{
    public class JsTemplatesContext
    {
        public JsTemplatesContext()
        {
            Templates = new HashSet<string>();
        }

        public HashSet<string> Templates { get; private set; }

        public void Require(string templateName)
        {
            if (!string.IsNullOrEmpty(templateName))
            {
                Templates.Add(templateName);
            }
        }
    }
}