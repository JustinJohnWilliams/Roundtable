using Roundtable.Contracts.Location;
using Roundtable.Contracts.Presenter;

namespace Roundtable.Contracts.Talk
{
    public interface IDetailedTalk: ITalk, ILocation, IPresenter
    {
         
    }
}