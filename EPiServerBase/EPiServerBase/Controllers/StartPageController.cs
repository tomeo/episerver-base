using System.Web.Mvc;
using Domain.Entities.EPiServer.Pages;
using EPiServer.Web.Mvc;

namespace EPiServerBase.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}