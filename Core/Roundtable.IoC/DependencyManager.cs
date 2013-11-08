using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Location;
using Roundtable.Contracts.Presenter;
using Roundtable.Contracts.Talk;
using Roundtable.DAL.Location;
using Roundtable.DAL.Presenter;
using Roundtable.DAL.Talk;
using Roundtable.Services.Location;
using Roundtable.Services.Presenter;
using Roundtable.Services.Talk;
using StructureMap;

namespace Roundtable.IoC
{
    public static class DependencyManager
    {
        public static IContainer BuildContainer()
        {
            IContainer container = IoCContainer.Initialize();
            var rtConnectionString = ConfigurationManager.ConnectionStrings["Roundtable"].ConnectionString;

            container.Configure(x =>
            {
                //DAL
                x.For<IPresenterRetriever>().Use<PresenterRepository>().Ctor<string>("connectionString").Is(rtConnectionString);
                x.For<IPresenterSaver>().Use<PresenterRepository>().Ctor<string>("connectionString").Is(rtConnectionString);
                x.For<ILocationSaver>().Use<LocationRepository>().Ctor<string>("connectionString").Is(rtConnectionString);
                x.For<ILocationRetriever>().Use<LocationRepository>().Ctor<string>("connectionString").Is(rtConnectionString);
                x.For<ITalkRetriever>().Use<TalkRepository>().Ctor<string>("connectionString").Is(rtConnectionString);


                //Services
                x.For<IPresenterService>().Use<PresenterService>();
                x.For<ILocationService>().Use<LocationService>();
                x.For<ITalkService>().Use<TalkService>();

            });

            return container;
        }
    }

    internal class IoCContainer
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x => x.Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            }));

            return ObjectFactory.Container;
        }
    }
}
