using System;
using System.Collections.Generic;
using Roundtable.Contracts.Presenter;

namespace Roundtable.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public List<IPresenter> Presenters { get; set; }

        public IndexViewModel()
        {
            Presenters = new List<IPresenter>();
        }
    }
}