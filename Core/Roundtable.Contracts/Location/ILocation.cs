using System;
namespace Roundtable.Contracts.Location
{
    public interface ILocation
    {
        Guid Id { get; }
        string Name { get; }
    }
}