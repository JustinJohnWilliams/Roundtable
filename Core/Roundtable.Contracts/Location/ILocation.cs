using System;
namespace Roundtable.Contracts.Location
{
    public interface ILocation
    {
        Guid LocationId { get; }
        string Name { get; }
    }
}