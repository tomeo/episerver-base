using System.Web.Mvc;
using Domain.Entities.EPiServer.Pages;
using Domain.Interfaces.Services;
using EPiServer;
using EPiServer.Web.Mvc;

namespace EPiServerBase.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly IPageService _pageService;
        private readonly IContentRepository _repository;

        public StartPageController(IPageService pageService, IContentRepository repository)
        {
            _pageService = pageService;
            _repository = repository;
        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}