using EPiServer.Core;

namespace Domain.Interfaces.Filter
{
    public interface IVisitorFilter
    {
        bool Filter(PageData page);
    }
}
