using System.Web.Mvc;
using Domain.Interfaces.Filter;
using Domain.Interfaces.Services;
using Domain.Services;
using Domain.Services.Filters;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Infrastructure.DependencyResolution
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    [InitializableModule]
    public class MvcTemplatesInitializer : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(x =>
            {
                x.For<IPageService>().Use<PageService>();
                x.For<INavigationService>().Use<NavigationService>();
                x.For<IVisitorFilterService>().Use<VisitorFilterService>();
                x.For<IVisitorFilter>().Use<ReadAccessVisitorFilter>();
                x.For<IVisitorFilter>().Use<VisibleInMenuVisitorFilter>();
            });

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
        }

        public void Initialize(InitializationEngine context) { }
        public void Uninitialize(InitializationEngine context) { }
        public void Preload(string[] parameters) { }
    }
}