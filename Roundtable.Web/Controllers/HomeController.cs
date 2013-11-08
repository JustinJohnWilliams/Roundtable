using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roundtable.Contracts.Presenter;
using Roundtable.Web.ViewModels.Home;

namespace Roundtable.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPresenterService _presenterService;
        //
        // GET: /Home/
        public HomeController(IPresenterService presenterService)
        {
            _presenterService = presenterService;
        }

        public ActionResult Index()
        {
            var vm = new IndexViewModel()
            {
                Presenters = _presenterService.GetPresenters()
            };

            return View(vm);
        }

    }
}
