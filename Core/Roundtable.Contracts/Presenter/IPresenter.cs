using System;

namespace Roundtable.Contracts.Presenter
{
    public interface IPresenter
    {
        Guid PresenterId { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}