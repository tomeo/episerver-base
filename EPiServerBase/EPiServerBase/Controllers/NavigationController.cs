using System.Web.Mvc;
using Domain.Interfaces.Services;

namespace EPiServerBase.Controllers
{
    public class NavigationController : Controller
    {
        private readonly INavigationService _navigationService;

        public NavigationController(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ActionResult Index()
        {
            return PartialView(_navigationService.GetNavigationModel());
        }
    }
}