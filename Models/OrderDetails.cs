using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int? OrderId { get; set; }
        public string ProductTitle { get; set; }
        public int? Quantity { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }

        public virtual Orders Order { get; set; }
    }
}
