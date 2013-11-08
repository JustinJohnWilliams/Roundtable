using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Presenter
{
    public interface IPresenterRetriever
    {
        List<IPresenter> GetPresenters(Func<IPresenter, bool> whereClause);
        List<IPresenter> GetPresenters();
    }
}