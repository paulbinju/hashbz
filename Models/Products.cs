using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public Guid? StoreId { get; set; }
        public int? UserId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Packing { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? Active { get; set; }

        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
