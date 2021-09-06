using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public string Location1 { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
