using System.Collections.Generic;
using EPiServer.Core;

namespace Domain.Interfaces.Services
{
    public interface INavigationService
    {
        IEnumerable<PageData> GetNavigationModel();
    }
}