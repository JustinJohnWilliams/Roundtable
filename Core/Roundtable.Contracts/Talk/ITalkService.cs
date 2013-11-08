using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Talk
{
    public interface ITalkService
    {
        List<IDetailedTalk> GetTalks();
        IDetailedTalk GetTalk(Guid id);
        Guid SaveTalk(ITalk talk);
    }
}