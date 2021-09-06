using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Subscription
    {
        public int SubscriptionId { get; set; }
        public Guid StoreId { get; set; }
        public int PackageId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
    }
}
