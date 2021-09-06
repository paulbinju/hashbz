using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class City
    {
        public City()
        {
            Customers = new HashSet<Customers>();
            Location = new HashSet<Location>();
            Store = new HashSet<Store>();
        }

        public int CityId { get; set; }
        public int? CountryId { get; set; }
        public string City1 { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
