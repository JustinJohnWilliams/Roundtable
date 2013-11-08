using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Talk
{
    public interface ITalkService
    {
        List<ITalk> GetTalks();
        ITalk GetTalk(Guid id);
        Guid SaveTalk(ITalk talk);
    }
}