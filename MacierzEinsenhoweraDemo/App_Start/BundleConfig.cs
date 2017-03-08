using System.Web;
using System.Web.Optimization;

namespace MacierzEinsenhoweraDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/site.css"));

            //Common
            bundles.Add(new ScriptBundle("~/bundles/common")
                .Include(
                    "~/Scripts/Project/namespaces.js",
                    "~/Scripts/Project/ApiHelper.js"
                ));

            //Matrix Component
            bundles.Add(new ScriptBundle("~/bundles/matrixComponent")
                .Include(
                    "~/Scripts/Project/Components/EinsenhowerMatrix/EinsenhowerMatrix.js",
                    "~/Scripts/Project/Components/EinsenhowerMatrix/EinsenhowerMatrixBaseModel.js",
                    "~/Scripts/Project/Components/EinsenhowerMatrix/EinsenhowerMatrixBaseControl.js",
                    "~/Scripts/Project/Components/EinsenhowerMatrix/Events.js",
                    "~/Scripts/Project/Components/JsMicroTemplate.js"
                ));

            //Single Matrix
            bundles.Add(new ScriptBundle("~/bundles/matrix")
                .Include(
                    "~/Scripts/Project/Matrix/SingleMatrix/MatrixController.js",
                    "~/Scripts/Project/Matrix/SingleMatrix/MatrixInit.js",
                    "~/Scripts/Project/Matrix/SingleMatrix/MatrixView.js",
                    "~/Scripts/Project/Matrix/SingleMatrix/Matrix/SingleMatrixModel.js",
                    "~/Scripts/Project/Matrix/SingleMatrix/Matrix/SingleMatrixControl.js",
                    "~/Scripts/Project/Matrix/Events.js"
                ));

            bundles.Add(new StyleBundle("~/Content/matrix").Include(
                "~/Content/Project/SingleMatrix.css"
                ));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
