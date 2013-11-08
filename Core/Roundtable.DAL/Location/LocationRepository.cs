using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Location;
using Roundtable.DAL.Location.Database;

namespace Roundtable.DAL.Location
{
    public class LocationRepository: ILocationRetriever, ILocationSaver
    {
        private readonly string _connectionString;

        public LocationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ILocation> GetLocations(Func<ILocation, bool> whereClause = null)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                var locations = whereClause == null ? db.Locations : db.Locations.Where(whereClause);

                return locations.ToList();
            }
        }

        public Guid SaveLocation(ILocation location)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                var locationDto = db.Locations.FirstOrDefault(l => l.Id == location.Id);

                if (locationDto == null || location.Id == Guid.Empty)
                {
                    locationDto = new LocationDto() { Id = Guid.NewGuid() } ;

                    db.Locations.InsertOnSubmit(locationDto);
                }

                locationDto.Name = location.Name;

                db.SubmitChanges();

                return locationDto.Id;
            }
        }
    }
}
