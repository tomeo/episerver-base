using System.Web.Mvc;
using Domain.Entities.EPiServer.Pages;
using EPiServer.Web.Mvc;

namespace EPiServerBase.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}