using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Location;

namespace Roundtable.Services.Location
{
    public class LocationService: ILocationService
    {
        private readonly ILocationRetriever _locationRetriever;
        private readonly ILocationSaver _locationSaver;

        public LocationService(ILocationRetriever locationRetriever, ILocationSaver locationSaver)
        {
            _locationRetriever = locationRetriever;
            _locationSaver = locationSaver;
        }

        public List<ILocation> GetLocations()
        {
            return _locationRetriever.GetLocations();
        }

        public ILocation GetLocation(Guid id)
        {
            return _locationRetriever.GetLocations(l => l.Id == id).FirstOrDefault();
        }

        public Guid SaveLocation(ILocation location)
        {
            return _locationSaver.SaveLocation(location);
        }
    }
}
