using System.Web.Mvc;
using Domain.Interfaces.Services;
using Domain.Services;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace EPiServerBase
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
            });

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
        }

        public void Initialize(InitializationEngine context) { }
        public void Uninitialize(InitializationEngine context) { }
        public void Preload(string[] parameters) { }
    }
}