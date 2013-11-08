using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Talk
{
    public interface ITalkRetriever
    {
        List<ITalk> GetTalks(Func<ITalk, bool> whereClause = null);
    }
}