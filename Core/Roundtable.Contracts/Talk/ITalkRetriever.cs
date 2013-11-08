using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Talk
{
    public interface ITalkRetriever
    {
        List<IDetailedTalk> GetTalks(Func<IDetailedTalk, bool> whereClause = null);
    }
}