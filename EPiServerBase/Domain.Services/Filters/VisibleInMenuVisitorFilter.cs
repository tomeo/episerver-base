using Domain.Interfaces.Filter;
using EPiServer.Core;

namespace Domain.Services.Filters
{
    public class VisibleInMenuVisitorFilter : IVisitorFilter
    {
        public bool Filter(PageData page)
        {
            return page.VisibleInMenu;
        }
    }
}
