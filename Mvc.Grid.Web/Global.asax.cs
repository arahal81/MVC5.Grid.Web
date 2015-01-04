﻿using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace NonFactors.Mvc.Grid.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
