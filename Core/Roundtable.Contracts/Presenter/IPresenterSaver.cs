using System;

namespace Roundtable.Contracts.Presenter
{
    public interface IPresenterSaver
    {
        Guid SavePresenter(IPresenter presenter);
    }
}