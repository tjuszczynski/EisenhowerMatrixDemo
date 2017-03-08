using MacierzEinsenhoweraDemo.Models.ViewModels;
using System.Web.Mvc;

namespace MacierzEinsenhoweraDemo.Controllers
{
    public class SingleMatrixController : Controller
    {
        // GET: MatrixView
        public ActionResult Index()
        {
            return View(new SingleMatrixViewModel());
        }
    }
}