using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Store
    {
        public Store()
        {
            StoreUser = new HashSet<StoreUser>();
            Subscription = new HashSet<Subscription>();
        }

        public Guid StoreId { get; set; }
        public int StoreNo { get; set; }
        public string StoreName { get; set; }
        public string Url { get; set; }
        public string Profile { get; set; }
        public string FacebookUrl { get; set; }
        public string GooglePlusUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? LocationId { get; set; }
        public string EmailId { get; set; }
        public bool EmailVerified { get; set; }
        public bool? DisplayEmail { get; set; }
        public string PhoneNo { get; set; }
        public bool PhoneVerified { get; set; }
        public bool? DisplayPhone { get; set; }
        public string Building { get; set; }
        public string Road { get; set; }
        public string Landmark { get; set; }
        public string CommercialName { get; set; }
        public string CommercialRegNo { get; set; }
        public string TaxNo { get; set; }
        public string HeaderPic { get; set; }
        public string Logo { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int? CurrencyId { get; set; }
        public bool? Active { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<StoreUser> StoreUser { get; set; }
        public virtual ICollection<Subscription> Subscription { get; set; }
    }
}
