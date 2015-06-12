using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces.Filter;
using Domain.Interfaces.Services;
using EPiServer.Core;

namespace Domain.Services
{
    public class VisitorFilterService : IVisitorFilterService
    {
        private readonly IEnumerable<IVisitorFilter> _filters;

        public VisitorFilterService(IEnumerable<IVisitorFilter> filters)
        {
            _filters = filters;
        }

        public IEnumerable<T> Filter<T>(IEnumerable<T> pages) where T : PageData
        {
            return pages.Where(p => _filters.All(f => f.Filter(p)));
        }
    }
}