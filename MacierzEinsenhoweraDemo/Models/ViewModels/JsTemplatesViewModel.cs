using System.Collections.Generic;

namespace MacierzEinsenhoweraDemo.Models.ViewModels
{
    public class JsTemplatesViewModel
    {
        public HashSet<string> Templates { get; set; }

        public JsTemplatesViewModel()
        {
            Templates = new HashSet<string>();
        }

        public void Require(string jsTemplateName)
        {
            Templates.Add(jsTemplateName);
        }
    }
}