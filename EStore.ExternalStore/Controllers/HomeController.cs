using System.Web.Mvc;
using EStore.ExternalStore.Models;
using EStore.ExternalStore.Templates;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        //Main Index For EStore Application.
        public ActionResult Index()
        {
            return View();
        }

        //Main Template Index Page
        public ActionResult YurEStore()
        {
            SEOModel templateData = TemplateRepository.GetTemplateThemeIndex("YurEStore");
            if (templateData == null)
                return View("~/Views/Shared/Error.cshtml");
            ViewBag.Title = templateData.Title;
            ViewBag.BodyClass = "YurEStore-Index";
            ViewBag.Canonical = "MyEstore.Canonical"; //Where(x => x.MyEstore.Id)...

            return View("~/Views/Templates/SEO_TemplateTheme.cshtml", templateData);
        }

        //Store Template Products List Page

        //Cart Template Items List Page

        //Checkout Template Items List Page


        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
