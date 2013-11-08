using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Roundtable.IoC;
using Roundtable.IoC.Resolvers.Structuremap;

namespace Roundtable.Web
{
    public static class DependencyConfig
    {
        public static void RegisterContainers()
        {
            var container = DependencyManager.BuildContainer();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver(container);
            
        }
    }
}