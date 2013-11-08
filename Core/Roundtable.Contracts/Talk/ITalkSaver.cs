using System;

namespace Roundtable.Contracts.Talk
{
    public interface ITalkSaver
    {
        Guid SaveTalk(ITalk talk);
        void DeleteTalk(Guid talkId);
    }
}