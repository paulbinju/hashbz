using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string FlatVillaNo { get; set; }
        public string BuildingNo { get; set; }
        public string RoadNo { get; set; }
        public string BlockNo { get; set; }
        public string Landmark { get; set; }
        public int? LocationId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
