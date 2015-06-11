using Domain.Entities.EPiServer.Pages;
using Domain.Interfaces.Services;
using EPiServer;
using EPiServer.Core;

namespace Domain.Services
{
    public class PageService : IPageService
    {
        private readonly IContentRepository _repository;

        public PageService(IContentRepository repository)
        {
            _repository = repository;
        }

        public StartPage GetStartPage()
        {
            return _repository.Get<StartPage>(ContentReference.StartPage);
        }
    }
}