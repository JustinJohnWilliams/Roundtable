using System;

namespace Roundtable.Contracts.Talk
{
    public interface ITalk
    {
        Guid Id { get; }
        string Topic { get; }
        Guid PresenterId { get; }
        Guid LocationId { get; }
    }
}