using Domain.Interfaces.Filter;
using EPiServer.Core;
using EPiServer.Security;

namespace Domain.Services.Filters
{
    public class ReadAccessVisitorFilter : IVisitorFilter
    {
        public bool Filter(PageData page)
        {
            return page.QueryDistinctAccess(AccessLevel.Read);
        }
    }
}