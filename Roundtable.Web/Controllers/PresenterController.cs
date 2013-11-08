using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roundtable.Contracts.Presenter;
using Roundtable.Web.ViewModels.Presenter;

namespace Roundtable.Web.Controllers
{
    public class PresenterController : Controller
    {
        private readonly IPresenterService _presenterService;
        //
        // GET: /Presenter/
        public PresenterController(IPresenterService presenterService)
        {
            _presenterService = presenterService;
        }

        public ActionResult Index()
        {
            var vm = new PresenterIndexViewModel
            {
                Presenters = _presenterService.GetPresenters()
            };

            return View(vm);
        }

    }
}
