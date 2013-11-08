using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Roundtable.Contracts.Location;

namespace Roundtable.Web.ViewModels.Location
{
    public class LocationEditViewModel: ILocation
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}