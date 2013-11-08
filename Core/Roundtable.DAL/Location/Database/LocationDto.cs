using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Location;

namespace Roundtable.DAL.Location.Database
{
    [Table(Name = "Locations")]
    public class LocationDto: ILocation
    {
        [Column(IsPrimaryKey = true)]
        public Guid Id { get; set; }

        [Column]
        public string Name { get; set; }
    }
}
