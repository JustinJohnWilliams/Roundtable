using System;

namespace Roundtable.Contracts.Talk
{
    public interface ITalk
    {
        Guid TalkId { get; }
        string Topic { get; }
        Guid PresenterId { get; }
        Guid LocationId { get; }
    }
}