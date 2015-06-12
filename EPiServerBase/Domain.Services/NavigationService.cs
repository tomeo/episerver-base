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

        public NavigationService(
            IPageService pageService,
            IContentRepository repository)
        {
            _pageService = pageService;
            _repository = repository;
        }

        public IEnumerable<PageData> GetNavigationModel()
        {
            // TODO: Add filtering and tests
            return _repository.GetChildren<PageData>(_pageService.GetStartPage().ContentLink);
        }
    }
}