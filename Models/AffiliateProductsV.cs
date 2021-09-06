using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class AffiliateProductsV
    {
        public int AffiliateProductId { get; set; }
        public int? AffiliateId { get; set; }
        public string Title { get; set; }
        public string ProductScript { get; set; }
        public string Description { get; set; }
        public string Urltitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaImage { get; set; }
        public DateTime? Doc { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
    }
}
