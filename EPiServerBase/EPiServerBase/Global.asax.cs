using System;
using System.Web.Mvc;
using System.Web.Optimization;
using EPiServerBase.App_Start;

namespace EPiServerBase
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}