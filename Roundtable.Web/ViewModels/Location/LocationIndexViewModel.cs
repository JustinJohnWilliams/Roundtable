using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roundtable.Contracts.Location;

namespace Roundtable.Web.ViewModels.Location
{
    public class LocationIndexViewModel
    {
        public List<ILocation> Locations { get; set; }
    }
}