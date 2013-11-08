using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Presenter;

namespace Roundtable.Services.Presenter
{
    public class PresenterService: IPresenterService
    {
        private readonly IPresenterRetriever _presenterRetriever;
        private readonly IPresenterSaver _presenterSaver;

        public PresenterService(IPresenterRetriever presenterRetriever, IPresenterSaver presenterSaver)
        {
            _presenterRetriever = presenterRetriever;
            _presenterSaver = presenterSaver;
        }

        public List<IPresenter> GetPresenters()
        {
            return _presenterRetriever.GetPresenters();
        }

        public IPresenter GetPresenter(Guid id)
        {
            return _presenterRetriever.GetPresenters(p => p.Id == id).FirstOrDefault();
        }

        public Guid SavePresenter(IPresenter presenter)
        {
            return _presenterSaver.SavePresenter(presenter);
        }
    }
}
