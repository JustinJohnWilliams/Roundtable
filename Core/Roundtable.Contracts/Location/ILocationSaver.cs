using System;

namespace Roundtable.Contracts.Location
{
    public interface ILocationSaver
    {
        Guid SaveLocation(ILocation location);
    }
}