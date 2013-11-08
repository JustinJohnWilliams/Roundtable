using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roundtable.Contracts.Presenter;

namespace Roundtable.Web.ViewModels.Presenter
{
    public class PresenterIndexViewModel
    {
        public List<IPresenter> Presenters { get; set; }
    }
}