namespace MacierzEinsenhoweraDemo.Models.ViewModels
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            JsTemplates = new JsTemplatesViewModel();
        }
        public JsTemplatesViewModel JsTemplates { get; private set; }
    }
}