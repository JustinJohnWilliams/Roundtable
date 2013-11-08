using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roundtable.Contracts.Location;
using Roundtable.Web.ViewModels.Location;

namespace Roundtable.Web.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public ActionResult Index()
        {
            var vm = new LocationIndexViewModel
            {
                Locations = _locationService.GetLocations()
            };

            return View(vm);
        }

        public ActionResult View(Guid? locationId)
        {
            if (locationId.HasValue)
            {
                return View(_locationService.GetLocation(locationId.Value));
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new LocationEditViewModel());
        }

        [HttpPost]
        public ActionResult Create(LocationEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                var newId = _locationService.SaveLocation(model);

                return RedirectToAction("View", new {id = newId});
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(Guid? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            var loc = _locationService.GetLocation(id.Value);
            var vm = new LocationEditViewModel();

            if (loc != null)
            {
                vm.Name = loc.Name;
                vm.LocationId = loc.LocationId;
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(LocationEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _locationService.SaveLocation(model);

                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}
