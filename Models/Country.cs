using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            Customers = new HashSet<Customers>();
            Location = new HashSet<Location>();
            Store = new HashSet<Store>();
        }

        public int CountryId { get; set; }
        public string Country1 { get; set; }
        public string Currency { get; set; }
        public string CurrencyCode { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
