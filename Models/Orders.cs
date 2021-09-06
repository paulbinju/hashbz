using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public Guid? StoreId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string FlatVillaNo { get; set; }
        public string BuildingNo { get; set; }
        public string RoadNo { get; set; }
        public string BlockNo { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? GrandTotal { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
