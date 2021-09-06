using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Apdetails
    {
        public int ApdetailsId { get; set; }
        public int? MediaTypeId { get; set; }
        public int? AffiliateProductsId { get; set; }
        public string Details { get; set; }
    }
}
