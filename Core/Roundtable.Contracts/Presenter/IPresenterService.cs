using System;
using System.Collections.Generic;

namespace Roundtable.Contracts.Presenter
{
    public interface IPresenterService
    {
        List<IPresenter> GetPresenters();
        IPresenter GetPresenter(Guid id);
        Guid SavePresenter(IPresenter presenter);
    }
}