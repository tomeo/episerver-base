using System.Collections.Generic;
using Domain.Interfaces.Services;
using EPiServer;
using EPiServer.Core;

namespace Domain.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IPageService _pageService;
        private readonly IContentRepository _repository;
        private readonly IVisitorFilterService _visitorFilterService;

        public NavigationService(
            IPageService pageService,
            IContentRepository repository,
            IVisitorFilterService visitorFilterService)
        {
            _pageService = pageService;
            _repository = repository;
            _visitorFilterService = visitorFilterService;
        }

        public IEnumerable<PageData> GetNavigationModel()
        {
            return _visitorFilterService.Filter(
                _repository.GetChildren<PageData>(_pageService.GetStartPage().ContentLink));
        }
    }
}