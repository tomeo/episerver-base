using System.Collections.Generic;
using EPiServer.Core;

namespace Domain.Interfaces.Services
{
    public interface IVisitorFilterService
    {
        IEnumerable<T> Filter<T>(IEnumerable<T> pages) where T : PageData;
    }
}