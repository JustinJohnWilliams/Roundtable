using System;

namespace Roundtable.Contracts.Presenter
{
    public interface IPresenter
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}