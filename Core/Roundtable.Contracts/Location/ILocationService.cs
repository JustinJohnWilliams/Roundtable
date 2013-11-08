using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Location
{
    public interface ILocationService
    {
        List<ILocation> GetLocations();
        ILocation GetLocation(Guid id);
        Guid SaveLocation(ILocation location);
    }
}