using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Location
{
    public interface ILocationRetriever
    {
        List<ILocation> GetLocations(Func<ILocation, bool> whereClause = null);
    }
}